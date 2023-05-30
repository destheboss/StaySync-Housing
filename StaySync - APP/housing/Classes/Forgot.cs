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

namespace housing.Classes
{
    public partial class Forgot : Form
    {
        private ForgetManager _forget = new ForgetManager();
        private PersonManager _manager;
        public Forgot(PersonManager m)
        {
            InitializeComponent();
            this.btnClose.DialogResult = DialogResult.Cancel;
            _manager = m;
            panelCode.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Main windowOpen = new Main();
            this.Hide();
            windowOpen.ShowDialog();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._forget.IsPhoneValid(tbxNumber.Texts))
                {
                    this._forget.GenerateNumber();
                    this._forget.ItIsSMSTime(tbxNumber.Texts);
                    panelCode.Visible = true;
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.");
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._forget.IsRandomNumberCorrect(Convert.ToInt32(tbxCode.Texts)))
                {
                    List<Person> persons = this._manager.GetList();
                    this._forget.SearchData(tbxNumber.Texts, persons);
                    RJMessageBox.Show("The code is correct! Your details have been sent to your email.");
                    Main windowOpen = new Main();
                    this.Hide();
                    windowOpen.ShowDialog();
                    this.Close();
                }
                else
                {
                    RJMessageBox.Show("The code is incorrect! Try again.");
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("The code is incorrect! Try again.");
            }

        }
    }
}
