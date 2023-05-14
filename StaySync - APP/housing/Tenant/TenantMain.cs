using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing
{
    public partial class TenantMain : Form
    {
        PersonManager manager;
        public TenantMain(PersonManager m)
        {
            manager = m;
            InitializeComponent();
            hideSubMenu();
            openChildForm(new Announce());
            this.manager = manager;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void hideSubMenu()
        {
            panelInformation.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInformation);
        }

        private void btnAnnounce_Click(object sender, EventArgs e)
        {
            openChildForm(new Announce());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Main windowOpen = new Main();
            this.Hide();
            windowOpen.ShowDialog();
            this.Close();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            openChildForm(new Rules());
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            openChildForm(new Contact());
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new TenantAttendance());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new TenantChores());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new TenantAgenda());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new TenantComplaints());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new TenantStock());
        }
    }
}
