using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Components
{
    public class TransparentPanel : Panel
    {

        private int _opacity = 100; // 0-255

        public int Opacity
        {
            get => _opacity;
            set
            {
                if (value < 0) value = 0;
                if (value > 255) value = 255;
                _opacity = value;
                this.Invalidate(); // Redraw
            }
        }

        public TransparentPanel()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(_opacity, Color.Black); // Default color
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(_opacity, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

    }
}
