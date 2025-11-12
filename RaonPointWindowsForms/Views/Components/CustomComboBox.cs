using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Components
{
    public class CustomComboBox : ComboBox
    {
        private Color _backColor = Color.FromArgb(45, 45, 45);
        private Color _borderColor = Color.DeepSkyBlue;
        private Color _iconColor = Color.White;
        private Color _listBackColor = Color.FromArgb(45, 45, 45);
        private Color _listTextColor = Color.White;
        private Color _textColor = Color.White;
        private int _borderSize = 2;
        private int _cornerRadius = 6;

        public CustomComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font(this.Font.Name, 10f);
            this.ForeColor = _textColor;
            this.BackColor = _backColor;
            this.MinimumSize = new Size(100, 30);
            this.SetStyle(ControlStyles.UserPaint, true); // <- crucial for border fix
        }

        [Category("Custom Appearance")]
        public Color BackgroundColor
        {
            get => _backColor;
            set { _backColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public Color IconColor
        {
            get => _iconColor;
            set { _iconColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public Color ListBackColor
        {
            get => _listBackColor;
            set { _listBackColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public Color ListTextColor
        {
            get => _listTextColor;
            set { _listTextColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public Color TextColor
        {
            get => _textColor;
            set { _textColor = value; this.ForeColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); this.Invalidate(); }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color backColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? _borderColor
                : _listBackColor;

            using (SolidBrush brush = new SolidBrush(backColor))
                g.FillRectangle(brush, e.Bounds);

            string text = GetItemText(Items[e.Index]);
            using (SolidBrush textBrush = new SolidBrush(_listTextColor))
                g.DrawString(text, this.Font, textBrush, e.Bounds.X + 5, e.Bounds.Y + 3);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = GetRoundedPath(rect, _cornerRadius))
            using (SolidBrush backBrush = new SolidBrush(_backColor))
            using (Pen borderPen = new Pen(_borderColor, _borderSize))
            {
                g.FillPath(backBrush, path);
                g.DrawPath(borderPen, path);
            }

            // Text
            Rectangle textRect = new Rectangle(8, 0, this.Width - 30, this.Height);
            TextRenderer.DrawText(g, this.Text, this.Font, textRect, _textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            // Drop-down arrow
            int arrowX = this.Width - 18;
            int arrowY = this.Height / 2 - 2;
            using (Pen pen = new Pen(_iconColor, 2))
            {
                g.DrawLine(pen, arrowX - 5, arrowY - 2, arrowX, arrowY + 3);
                g.DrawLine(pen, arrowX + 5, arrowY - 2, arrowX, arrowY + 3);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.DropDown += (s, ev) =>
            {
                this.BackColor = _listBackColor;
                this.ForeColor = _listTextColor;
            };
        }
    }
}
