using housing.Classes;
using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing
{
    public partial class Announce : Form
    {
        private AnnouncementManager announcements;
        public Announce()
        {
            InitializeComponent();
            announcements = new AnnouncementManager();
            LoadAnnouncements();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshAnnouncementList()
        {
            this.lbxAnnouncements.Items.Clear();
            foreach (var announcement in announcements.GetAnnouncements())
            {
                this.lbxAnnouncements.Items.Add(announcement.GetAnnouncement());
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
                RJMessageBox.Show("The file could not be read");
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lbxAnnouncements.SelectedIndex > -1)
            {
                int index = this.lbxAnnouncements.SelectedIndex;
                if (index > -1)
                {
                    index++;
                    RJMessageBox.Show(announcements.GetAnnouncementMessageBasedOnId(index));
                }
            }
            else
            {
                RJMessageBox.Show("Please select an announcement first.", "", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAnnouncementList();
        }

        private void lbxAnnouncements_DoubleClick(object sender, EventArgs e)
        {
            if (lbxAnnouncements.SelectedIndex > -1)
            {
                int index = this.lbxAnnouncements.SelectedIndex;
                if (index > -1)
                {
                    index++;
                    RJMessageBox.Show(announcements.GetAnnouncementMessageBasedOnId(index));
                }
            }
        }
    }
}
