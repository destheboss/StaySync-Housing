using housing.Classes;
using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace housing
{
    public partial class TenantComplaints : Form
    {
        private PersonManager _manager;
        private ComplaintManager _complaintManager;
        public TenantComplaints(PersonManager manager)
        {
            InitializeComponent();
            _manager = manager;
            _complaintManager = new ComplaintManager();
            tenantRbtn.CheckedChanged += RadioButton_CheckedChanged;
            adminRbtn.CheckedChanged += RadioButton_CheckedChanged;
            roomRbtn.CheckedChanged += RadioButton_CheckedChanged;

            tenantCMB.Enabled = false;
            adminCMB.Enabled = false;
            roomCMB.Enabled = false;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tenantCMB.Enabled = tenantRbtn.Checked;
            adminCMB.Enabled = adminRbtn.Checked;
            roomCMB.Enabled = roomRbtn.Checked;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxComplaint.Texts))
                {
                    RJMessageBox.Show("Please write a complaint.");
                    return;
                }

                if (!_complaintManager.IsAnyRadioButtonChecked(tenantRbtn.Checked, adminRbtn.Checked, roomRbtn.Checked))
                {
                    generalRbtn.Checked = true;
                }

                if (_complaintManager.IsItEmpty(tenantRbtn.Checked, adminRbtn.Checked, roomRbtn.Checked, tenantCMB.Texts, adminCMB.Texts, roomCMB.Texts))
                {
                    RJMessageBox.Show("Please make sure to select a name/room.");
                    return;
                }

                string subject = GetComplaintSubject();
                string whoOrWhere = GetComplaintWhoOrWhere();
                string complaintText = tbxComplaint.Texts;

                if (tenantRbtn.Checked && !string.IsNullOrWhiteSpace(tenantCMB.Texts) && !tenantCMB.Items.Contains(tenantCMB.Texts))
                {
                    RJMessageBox.Show("Please select a name from the dropdown list.");
                    return;
                }

                if (adminRbtn.Checked && !string.IsNullOrWhiteSpace(adminCMB.Texts) && !adminCMB.Items.Contains(adminCMB.Texts))
                {
                    RJMessageBox.Show("Please select a name from the dropdown list.");
                    return;
                }

                if (roomRbtn.Checked && !string.IsNullOrWhiteSpace(roomCMB.Texts) && !roomCMB.Items.Contains(roomCMB.Texts))
                {
                    RJMessageBox.Show("Please select a room from the dropdown list.");
                    return;
                }

                _complaintManager.FileComplaint(subject, whoOrWhere, complaintText);
                _complaintManager.WriteComplaints();
                RJMessageBox.Show("Complaint was filed successfully");
            }
            catch (Exception)
            {
                RJMessageBox.Show("Please make sure to select a name/room and write a complaint.");
            }
        }

        private string GetComplaintSubject()
        {
            if (tenantRbtn.Checked)
                return "TENANT";
            else if (adminRbtn.Checked)
                return "ADMIN";
            else if (roomRbtn.Checked)
                return "ROOM";
            else
                return "GENERAL";
        }

        private string GetComplaintWhoOrWhere()
        {
            if (tenantRbtn.Checked)
                return tenantCMB.Texts;
            else if (adminRbtn.Checked)
                return adminCMB.Texts;
            else if (roomRbtn.Checked)
                return roomCMB.Texts;
            else
                return "";
        }

        private void TenantComplaints_Load(object sender, EventArgs e)
        {
            tenantCMB.Items.Clear();
            roomCMB.Items.Clear();

            ComplaintLoader complaintLoader = new ComplaintLoader();
            List<Person> people = _manager.GetList();
            try
            {
                foreach (Person person in people)
                {
                    if (!complaintLoader.IsItYourself(person))
                    {
                        if (complaintLoader.IsItATenant(person))
                        {
                            tenantCMB.Items.Add(complaintLoader.WriteTenant(person));
                        }
                        else
                        {
                            adminCMB.Items.Add(complaintLoader.WriteAdmin(person));
                        }

                        if (person.RoomNumber != 0)
                        {
                            roomCMB.Items.Add(person.RoomNumber.ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.");
            }

        }

        private void btnViewComplaints_Click(object sender, EventArgs e)
        {
            ComplaintViewer form = new ComplaintViewer();
            form.Show();
        }
    }
}
