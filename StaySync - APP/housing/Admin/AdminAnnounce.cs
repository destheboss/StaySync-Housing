using housing.Classes;
using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing
{
    public partial class AdminAnnounce : Form
    {
        private AnnouncementManager announcements;
        public AdminAnnounce()
        {
            InitializeComponent();
            announcements = new AnnouncementManager();
            LoadAnnouncements();
        }

        private void RefreshAnnouncementList()
        {
            try
            {
                this.lbxAnnounce.Items.Clear();
                foreach (var announcement in announcements.GetAnnouncements())
                {
                    this.lbxAnnounce.Items.Add(announcement.GetAnnouncement());
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        public void LoadAnnouncements()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string[] files = Directory.GetFiles(desktopPath, "announcement.txt", SearchOption.AllDirectories);
                string fullPath = files.First();

                string[] lines = File.ReadAllLines(fullPath);

                foreach (string line in lines)
                {
                    announcements.AddAnnouncement(line);
                    RefreshAnnouncementList();
                }
            }
            catch (IOException)
            {
                RJMessageBox.Show("The file could not be read.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string announce = tbxMessage.Texts;
                if (!String.IsNullOrEmpty(announce))
                {
                    announcements.AddAnnouncement(announce);
                    RefreshAnnouncementList();
                    tbxMessage.Texts = "";
                    RJMessageBox.Show("Announcement added.", "", MessageBoxButtons.OK);
                }
                else
                {
                    RJMessageBox.Show("Please supply a valid message.", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxAnnounce.SelectedIndex > -1)
                {
                    int index = this.lbxAnnounce.SelectedIndex;
                    {
                        index++;
                        announcements.DeleteAnnouncement(index);
                        RJMessageBox.Show("Announcement deleted.", "", MessageBoxButtons.OK);
                        RefreshAnnouncementList();
                    }
                }
                else
                {
                    RJMessageBox.Show("Please select an announcement first.", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        private void AdminAnnounce_Leave(object sender, EventArgs e)
        {
            announcements.WriteToFile();
        }

        private void AdminAnnounce_ParentChanged(object sender, EventArgs e)
        {
            announcements.WriteToFile();
        }
    }
}
