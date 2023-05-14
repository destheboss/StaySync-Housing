using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing.CustomElements
{
    public class CustomTabControl : TabControl
    {
        // Define two colors for the selected and unselected tabs
        private Color selectedTabColor = Color.FromArgb(231, 34, 83);
        private Color unselectedTabColor = Color.FromArgb(87, 10, 35);
        public CustomTabControl()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            this.SelectedIndexChanged += (s, e) =>
            {
                // Invalidate the control to force a repaint whenever the selected tab changes
                this.Invalidate();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw the transparent background
            e.Graphics.Clear(Color.FromArgb(11, 7, 17));

            // Create your custom color
            Color customColor = Color.FromArgb(11, 7, 17);

            // Draw the border around the TabControl
            using (Pen borderPen = new Pen(customColor, 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }

            // Create the fill color for the area beneath the tabs
            Color fillColor = Color.FromArgb(87, 10, 35);
            using (Brush fillBrush = new SolidBrush(fillColor))
            {
                // Calculate the area to be filled
                Rectangle fillRect = this.ClientRectangle;

                // The area starts from a bit above the end of the last tab
                if (this.TabPages.Count > 0)
                {
                    fillRect.Y = this.GetTabRect(this.TabPages.Count - 1).Bottom - 3; // Change this value to adjust the top padding
                    fillRect.Height -= fillRect.Y;
                }

                // Draw the fill rectangle
                e.Graphics.FillRectangle(fillBrush, fillRect);
            }

            // Draw each tab
            for (int i = 0; i < this.TabPages.Count; i++)
            {
                TabPage tabPage = this.TabPages[i];
                Rectangle tabHeaderRect = this.GetTabRect(i);

                // If this tab is the currently selected one, make it larger and change color
                Brush tabHeaderBrush = (this.SelectedIndex == i) ? new SolidBrush(selectedTabColor) : new SolidBrush(unselectedTabColor);
                if (this.SelectedIndex == i)
                {
                    tabHeaderRect.Inflate(2, 2); // Change these values to adjust the size difference
                }

                // Draw the tab header
                e.Graphics.FillRectangle(tabHeaderBrush, tabHeaderRect);

                // Draw the tab text
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(tabPage.Text, this.Font, Brushes.White, tabHeaderRect, stringFormat);

                // Dispose the brush
                tabHeaderBrush.Dispose();
            }
        }

        // This is to remove the grayish background
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.BackColor = Color.FromArgb(231, 34, 83);
        }
    }

}
