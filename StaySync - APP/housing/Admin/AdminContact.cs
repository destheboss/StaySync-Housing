using housing.Classes;
using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing
{
    public partial class AdminContact : Form
    {
        private contactManager contact;
        private PersonManager _manager;
        public AdminContact(PersonManager manager)
        {
            InitializeComponent();
            contact = new contactManager();
            _manager = manager;

            ButtonDesignHelper.SetButtonStyles(btnClose);
            ButtonDesignHelper.SetImageButtonStyle(btnClose, btnClose.Image, housing.Properties.Resources.attendance_invert);
            btnClose.Text = $"  {_manager.CurrentUser.LastName}";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                contact.DeleteContacts();

                string phone = tbxPhone.Texts;
                string wapp = tbxWapp.Texts;
                string email = tbxEmail.Texts;
                string address = tbxAddress.Texts;

                if (string.IsNullOrWhiteSpace(phone) && string.IsNullOrWhiteSpace(wapp) && string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(address))
                { RJMessageBox.Show("Please input at least one detail."); }
                else
                {
                    contact.AddContact(phone, wapp, email, address);
                    RJMessageBox.Show("Changes were made.");
                }
                contact.Write();
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }

        private void FocusEvent(object sender, EventArgs e)
        {
            btnClose.Focus();
        }
    }
}
