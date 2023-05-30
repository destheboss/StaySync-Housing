using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace housing.Classes
{
    internal class AnnouncementManager
    {
        private int announcementSeeder;
        public List<Announcement> AllAnnouncements { get; set; }

        public AnnouncementManager()
        {
            this.AllAnnouncements = new List<Announcement>();
        }

        public void AddAnnouncement(string message)
        {
            this.announcementSeeder++;
            this.AllAnnouncements.Add(new Announcement(announcementSeeder, message));
        }

        public Announcement[] GetAnnouncements()
        {
            return this.AllAnnouncements.ToArray();
        }

        public Announcement GetAnnouncement(int id)
        {
            foreach (var announcement in this.AllAnnouncements)
            {
                if (id == announcement.ID)
                    return announcement;
            }
            return null;
        }

        public string GetAnnouncementMessageBasedOnId(int id)
        {
            var announcement = this.GetAnnouncement(id);
            return announcement != null ? announcement.GetAnnouncementMessage() : string.Empty;
        }

        public void DeleteAnnouncement(int id)
        {
            var announcement = this.GetAnnouncement(id);
            if (announcement != null)
                this.AllAnnouncements.Remove(announcement);
        }

        public void WriteToFile()
        {
            StreamWriter sw = null;

            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "announcement.txt";
                string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);

                if (files.Length > 0)
                {
                    string fullPath = files.First();
                    sw = new StreamWriter(fullPath, false); // Overwrite existing content

                    foreach (Announcement a in AllAnnouncements)
                    {
                        sw.WriteLine(a.WriteAnnouncementMessage());
                    }
                }
                else
                {
                    RJMessageBox.Show("The file could not be read.");
                }
            }
            catch (IOException)
            {
                RJMessageBox.Show("The file could not be read.", "", MessageBoxButtons.OK);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}
