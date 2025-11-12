using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Components
{
    public class CustomDateTimePicker : DateTimePicker
    {
        private Color _skinColor = Color.MediumSlateBlue;
        private Color _textColor = Color.White;
        private Color _borderColor = Color.PaleVioletRed;
        private int _borderSize = 2;
        private bool _droppedDown = false;

        public CustomDateTimePicker()
        {
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        [Category("Custom Appearance")]
        public Color SkinColor
        {
            get => _skinColor;
            set { _skinColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public Color TextColor
        {
            get => _textColor;
            set { _textColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; this.Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rectBorder = this.ClientRectangle;
            Rectangle rectText = new Rectangle(0, 0, this.Width - 20, this.Height);
            Rectangle rectIcon = new Rectangle(this.Width - 18, 4, 16, 16);

            // Fill background
            using (SolidBrush brush = new SolidBrush(_skinColor))
                g.FillRectangle(brush, rectBorder);

            // Draw text
            TextRenderer.DrawText(g, this.Text, this.Font, rectText, _textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            // Draw drop-down arrow
            using (Pen pen = new Pen(Color.White, 2))
            {
                g.DrawLine(pen, rectIcon.Left + 2, rectIcon.Top + 6, rectIcon.Left + 7, rectIcon.Top + 11);
                g.DrawLine(pen, rectIcon.Left + 12, rectIcon.Top + 6, rectIcon.Left + 7, rectIcon.Top + 11);
            }

            // Draw border
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            {
                g.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            _droppedDown = true;
            this.Invalidate();
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            _droppedDown = false;
            this.Invalidate();
        }
    }
}
