using housing.Classes;
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
        public AdminContact()
        {
            InitializeComponent();
            contact = new contactManager();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            contact.DeleteContacts();

            string phone = tbxPhone.Texts;
            string wapp = tbxWapp.Texts;
            string email = tbxEmail.Texts;
            string address = tbxAddress.Texts;

            if (string.IsNullOrWhiteSpace(phone) && string.IsNullOrWhiteSpace(wapp) && string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(address))
                MessageBox.Show("Please input at least one detail.");
            else
            {
                contact.AddContact(phone, wapp, email, address);
                MessageBox.Show("Changes were made.");
            }
            contact.Write();
        }
    }
}
