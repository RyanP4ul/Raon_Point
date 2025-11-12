using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Components
{
    public class RoundedBorderedPanel : Panel
    {
        private Color _borderColor = Color.Black;
        private int _borderThickness = 2;
        private int _borderRadius = 20;

        public RoundedBorderedPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        // Border color property
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        // Border thickness property
        public int BorderThickness
        {
            get => _borderThickness;
            set
            {
                _borderThickness = Math.Max(1, value);
                this.Invalidate();
            }
        }

        // Border radius property
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = Math.Max(0, value);
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(_borderColor, _borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                var rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

                if (_borderRadius > 0)
                {
                    using (GraphicsPath path = GetRoundRectangle(rect, _borderRadius))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
                else
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private GraphicsPath GetRoundRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left
            path.CloseFigure();

            return path;
        }
    }
}
