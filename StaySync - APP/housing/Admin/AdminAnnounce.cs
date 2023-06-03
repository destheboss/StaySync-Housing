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
        private PersonManager _manager;
        public AdminAnnounce(PersonManager manager)
        {
            InitializeComponent();
            _manager = manager;
            announcements = new AnnouncementManager();
            LoadAnnouncements();

            ButtonDesignHelper.SetButtonStyles(btnClose);
            ButtonDesignHelper.SetImageButtonStyle(btnClose, btnClose.Image, housing.Properties.Resources.attendance_invert);
            btnClose.Text = $"  {_manager.CurrentUser.LastName}";
        }

        private void RefreshAnnouncementList()
        {
            try
            {
                this.lbxAnnounce.Items.Clear();
                foreach (var announcement in announcements.GetAnnouncements())
                {
                    this.lbxAnnounce.Items.Add(announcement);
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
                    Announcement newAnnouncement = announcements.AddAnnouncement(announce);
                    this.lbxAnnounce.Items.Add(newAnnouncement);
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
                    DialogResult result = RJMessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Announcement announcementToDelete = (Announcement)this.lbxAnnounce.SelectedItem;
                        announcements.DeleteAnnouncement(announcementToDelete);
                        this.lbxAnnounce.Items.Remove(announcementToDelete);
                        RJMessageBox.Show("Announcement deleted.", "", MessageBoxButtons.OK);
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

        private void FocusEvent(object sender, EventArgs e)
        {
            btnClose.Focus();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            btnClose.Focus();
        }
    }
}
