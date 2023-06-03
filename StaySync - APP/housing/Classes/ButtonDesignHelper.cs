using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing.Classes
{
    public static class ButtonDesignHelper
    {
        private class ButtonImages
        {
            public Image Original { get; set; }
            public Image Inverted { get; set; }
        }

        private static Button activeButton = null;
        private static Dictionary<Button, ButtonImages> buttonImages = new Dictionary<Button, ButtonImages>();

        public static void SetButtonStyles(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                SetButtonStyle(button);
            }
        }

        public static void SetImageButtonStyle(Button button, Image originalImage, Image invertedImage)
        {
            SetButtonStyle(button);
            buttonImages[button] = new ButtonImages { Original = originalImage, Inverted = invertedImage };
        }

        public static void SetActiveButton(Button button)
        {
            if (activeButton != null)
            {
                ResetButtonStyle();
            }

            activeButton = button;

            HighlightButton();
        }

        private static void SetButtonStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.FromArgb(35, 32, 39);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 34, 83);
            button.FlatAppearance.BorderSize = 0;
            button.MouseEnter += Button_MouseEnter;
            button.MouseLeave += Button_MouseLeave;
        }

        private static void Button_MouseEnter(object sender, System.EventArgs e)
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

        private static void Button_MouseLeave(object sender, System.EventArgs e)
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

        private static void HighlightButton()
        {
            activeButton.BackColor = Color.FromArgb(231, 34, 83);
            activeButton.ForeColor = Color.FromArgb(11, 7, 17);
            if (buttonImages.ContainsKey(activeButton))
            {
                activeButton.Image = buttonImages[activeButton].Inverted;
            }
        }

        private static void ResetButtonStyle()
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

        private static Color GetOriginalButtonColor(Button button)
        {
            if (button.BackColor != Color.Empty)
            {
                return button.BackColor;
            }
            else
            {
                return Color.FromArgb(35, 32, 39);
            }
        }
    }
}