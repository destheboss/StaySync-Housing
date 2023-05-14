using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace housing.CustomElements
{
    public class RoundPanelListBox : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int borderRadius = 35;
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            grPath.AddLine(borderRadius, 0, this.Width - borderRadius, 0);
            grPath.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            grPath.AddLine(this.Width, borderRadius, this.Width, this.Height - borderRadius);
            grPath.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            grPath.AddLine(this.Width - borderRadius, this.Height, borderRadius, this.Height);
            grPath.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            grPath.AddLine(0, this.Height - borderRadius, 0, borderRadius);

            this.Region = new Region(grPath);

            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            this.Region = null;
            base.OnResize(eventargs);
        }
    }
}
