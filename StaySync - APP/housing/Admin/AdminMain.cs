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
    public partial class AdminMain : Form
    {
        private class ButtonImages
        {
            public Image Original { get; set; }
            public Image Inverted { get; set; }
        }

        private Button activeButton = null;
        private Dictionary<Button, ButtonImages> buttonImages = new Dictionary<Button, ButtonImages>();
        private PersonManager manager;
        private Form activeForm = null;

        public AdminMain(PersonManager m)
        {
            manager = m;
            InitializeComponent();
            hideSubMenu();
            openChildForm(new AdminAnnounce(m));
            SetButtonStyles();
            SetButtonImages();

            SetActiveButton(btnInformation);
        }

        private void SetButtonStyles()
        {
            SetButtonStyle(btnInformation);
            SetButtonStyle(btnAnnounce);
            SetButtonStyle(btnLogOut);
            SetButtonStyle(btnRules);
            SetButtonStyle(btnContact);
            SetButtonStyle(btnAttendance);
            SetButtonStyle(button1);
            SetButtonStyle(button2);
            SetButtonStyle(button3);
            SetButtonStyle(button4);
        }

        private void SetButtonImages()
        {
            SetImageButtonStyle(btnInformation, btnInformation.Image, housing.Properties.Resources.question_invert);
            SetImageButtonStyle(btnLogOut, btnLogOut.Image, housing.Properties.Resources.exit_invert);
            SetImageButtonStyle(btnAttendance, btnAttendance.Image, housing.Properties.Resources.attendance_invert);
            SetImageButtonStyle(button1, button1.Image, housing.Properties.Resources.chores_invert);
            SetImageButtonStyle(button2, button2.Image, housing.Properties.Resources.agenda_invert);
            SetImageButtonStyle(button3, button3.Image, housing.Properties.Resources.complaints_invert);
            SetImageButtonStyle(button4, button4.Image, housing.Properties.Resources.stock_invert);
        }

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
            {
                subMenu.Visible = false;
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInformation);
            SetActiveButton(btnAnnounce);
        }

        private void btnAnnounce_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminAnnounce(manager));
            SetActiveButton((Button)sender);
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
            openChildForm(new AdminRules(manager));
            SetActiveButton((Button)sender);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminContact(manager));
            SetActiveButton((Button)sender);
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminAttendance(manager));
            SetActiveButton((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChores(manager));
            SetActiveButton((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminAgenda(manager));
            SetActiveButton((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminComplaints(manager));
            SetActiveButton((Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminStock(manager));
            SetActiveButton((Button)sender);
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
            button.FlatAppearance.BorderSize = 0;
            button.MouseEnter += Button_MouseEnter;
            button.MouseMove += Button_MouseMove;
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

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                Button_MouseEnter(button, EventArgs.Empty);
            }
        }

        private void SetActiveButton(Button button)
        {
            if (activeButton != null)
            {
                ResetButtonStyle();
            }

            activeButton = button;

            HighlightButton();
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
            if (activeButton != null)
            {
                activeButton.BackColor = GetOriginalButtonColor(activeButton);
                activeButton.ForeColor = Color.Silver;
                if (buttonImages.ContainsKey(activeButton))
                {
                    activeButton.Image = buttonImages[activeButton].Original;
                }
            }
        }

        private Color GetOriginalButtonColor(Button button)
        {
            if (button == btnInformation)
            {
                return Color.FromArgb(11, 7, 17);
            }
            else if (button == btnAttendance)
            {
                return Color.FromArgb(11, 7, 17);
            }
            else if (button == button1)
            {
                return Color.FromArgb(11, 7, 17);
            }
            else if (button == button2)
            {
                return Color.FromArgb(11, 7, 17);
            }
            else if (button == button3)
            {
                return Color.FromArgb(11, 7, 17);
            }
            else if (button == button4)
            {
                return Color.FromArgb(11, 7, 17);
            }
            else if (button == btnLogOut)
            {
                return Color.FromArgb(11, 7, 17);
            }

            return Color.FromArgb(35, 32, 39);
        }
    }
}