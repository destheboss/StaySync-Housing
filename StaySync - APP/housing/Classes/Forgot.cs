using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.FormBorderStyle = FormBorderStyle.None;
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
                    List<Person> persons = this._manager.GetList();
                    if (!this._forget.DoesPhoneNumberExist(tbxNumber.Texts, persons))
                    {
                        RJMessageBox.Show("This phone number is not associated with any tenant.");
                        return;
                    }

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

        #region -> Drag Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void FocusEvent(object sender, EventArgs e)
        {
            btnSend.Focus();
        }
    }
}
