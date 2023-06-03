using housing.Classes;
using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing
{
    public partial class Main : Form
    {
        private class ButtonImages
        {
            public Image Original { get; set; }
            public Image Inverted { get; set; }
        }

        private Button activeButton = null;
        private Dictionary<Button, ButtonImages> buttonImages = new Dictionary<Button, ButtonImages>();
        private PersonManager _manager = new PersonManager();
        private Form activeForm = null;


        public Main()
        {
            InitializeComponent();
            SetButtonStyles();
            SetButtonImages();
        }

        private void SetButtonStyles()
        {
            SetButtonStyle(btnInformation);
            SetButtonStyle(btnAnnounce);
            SetButtonStyle(btnRules);
            SetButtonStyle(btnContact);
            SetButtonStyle(btnExit);
        }

        private void SetButtonImages()
        {
            SetImageButtonStyle(btnInformation, btnInformation.Image, housing.Properties.Resources.question_invert);
            SetImageButtonStyle(btnExit, btnExit.Image, housing.Properties.Resources.exit_invert);
        }

        private void openChildForm(Form childForm, Button senderButton)
        {
            if (activeButton != null)
            {
                ResetButtonStyle();
            }

            activeButton = senderButton;

            HighlightButton();

            if (activeForm != null)
            {
                activeForm.Closed -= ChildForm_Closed;
                activeForm.Close();
            }

            activeForm = childForm;
            activeForm.Closed += ChildForm_Closed;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ChildForm_Closed(object sender, EventArgs e)
        {
            if (activeButton != null)
            {
                ResetButtonStyle();
                activeButton = null;
            }
        }

        private void SetImageButtonStyle(Button button, Image originalImage, Image invertedImage)
        {
            SetButtonStyle(button);
            buttonImages[button] = new ButtonImages { Original = originalImage, Inverted = invertedImage };
        }

        private void SetButtonStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.FromArgb(35, 32, 39);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 34, 83);
            button.FlatAppearance.BorderSize = 0; // No border
            button.MouseEnter += Button_MouseEnter;
            button.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.ForeColor = Color.Black;
                if (buttonImages.ContainsKey(button))
                {
                    button.Image = buttonImages[button].Inverted;
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                if (button != activeButton)
                {
                    button.ForeColor = Color.Silver;
                    if (buttonImages.ContainsKey(button))
                    {
                        button.Image = buttonImages[button].Original;
                    }
                }
                else
                {
                    button.ForeColor = Color.Black;
                    if (buttonImages.ContainsKey(button))
                    {
                        button.Image = buttonImages[button].Inverted;
                    }
                }
            }
        }

        private void HighlightButton()
        {
            activeButton.BackColor = Color.FromArgb(231, 34, 83);
            activeButton.ForeColor = Color.FromArgb(11, 7, 17);
            if (buttonImages.ContainsKey(activeButton))
            {
                activeButton.Image = buttonImages[activeButton].Inverted;
            }
        }

        private void ResetButtonStyle()
        {
            activeButton.BackColor = Color.FromArgb(35, 32, 39);
            activeButton.ForeColor = Color.Silver;
            if (buttonImages.ContainsKey(activeButton))
            {
                activeButton.Image = buttonImages[activeButton].Original;
            }
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
            {
                subMenu.Visible = false;
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInformation);
        }

        private void btnAnnounce_Click(object sender, EventArgs e)
        {
            openChildForm(new Announce(), (Button)sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            openChildForm(new Rules(), (Button)sender);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            openChildForm(new Contact(), (Button)sender);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._manager.IsTheInputAcceptable(tbxCodeInput.Texts))
                {
                    if (this._manager.IsThePersonInTheCSV(Convert.ToInt32(tbxCodeInput.Texts)))
                    {
                        if (this._manager.IsThePersonAdmin())
                        {
                            AdminMain windowOpen = new AdminMain(this._manager);
                            RJMessageBox.Show("Welcome back < Admin >", "", MessageBoxButtons.OK);
                            this.Hide();
                            windowOpen.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            TenantMain windowOpen = new TenantMain(this._manager);
                            RJMessageBox.Show("Welcome back < Tenant >", "", MessageBoxButtons.OK);
                            this.Hide();
                            windowOpen.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        RJMessageBox.Show("Incorrect ID", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    RJMessageBox.Show("Input a correct ID", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Input a correct ID", "", MessageBoxButtons.OK);
            }
        }

        private void Forgotbtn_Click(object sender, EventArgs e)
        {
            Forgot windowOpen = new Forgot(this._manager);
            this.Hide();
            windowOpen.ShowDialog();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this._manager.LoadUpList();
        }

        private void tbxCodeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxCodeInput__TextChanged(object sender, EventArgs e)
        {
            if (tbxCodeInput.Texts.Length == 7) // Check if there are 7 characters in the textbox
            {
                if (this._manager.IsTheInputAcceptable(tbxCodeInput.Texts))
                {
                    if (this._manager.IsThePersonInTheCSV(Convert.ToInt32(tbxCodeInput.Texts)))
                    {
                        if (this._manager.IsThePersonAdmin())
                        {
                            AdminMain windowOpen = new AdminMain(this._manager);
                            RJMessageBox.Show($"Welcome back < {_manager.CurrentUser.LastName} >", "", MessageBoxButtons.OK);
                            this.Hide();
                            windowOpen.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            TenantMain windowOpen = new TenantMain(this._manager);
                            RJMessageBox.Show($"Welcome back < {_manager.CurrentUser.FirstName} >", "", MessageBoxButtons.OK);
                            this.Hide();
                            windowOpen.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        RJMessageBox.Show("Incorrect ID", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    RJMessageBox.Show("Input a correct ID", "", MessageBoxButtons.OK);
                }
            }
        }

        private void tbxCodeInput_Leave(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }

        private void panelBackground_Click(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }
    }
}
