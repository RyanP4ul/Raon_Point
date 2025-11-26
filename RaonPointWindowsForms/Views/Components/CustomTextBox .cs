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
    public class CustomTextBox : UserControl
    {

        private TextBox textBox;
        private Color _borderColor = Color.MediumSlateBlue;
        private int _borderSize = 2;
        private bool _underlinedStyle = false;
        private Color _borderFocusColor = Color.HotPink;
        private bool _isFocused = false;
        private int _borderRadius = 6;
        private string _placeholderText = "";
        private Color _placeholderColor = Color.Gray;
        private bool _isPlaceholder = false;

        // Track desired password state separately
        private bool _isPasswordChar = false;

        public CustomTextBox()
        {
            textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.None;
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(10, 7);
            textBox.Width = this.Width - 20;
            textBox.TextChanged += (s, e) => OnTextChanged(e);
            textBox.Enter += RemovePlaceholder;
            textBox.Leave += SetPlaceholder;
            this.Controls.Add(textBox);
            this.Padding = new Padding(10, 7, 10, 7);
            this.MinimumSize = new Size(0, 30);
            this.BackColor = Color.White;
        }

        [Category("Custom Appearance")]
        public string PlaceholderText
        {
            get => _placeholderText;
            set
            {
                _placeholderText = value;
                SetPlaceholder(null, null);
            }
        }

        [Category("Custom Appearance")]
        public Color PlaceholderColor
        {
            get => _placeholderColor;
            set
            {
                _placeholderColor = value;
                if (_isPlaceholder) textBox.ForeColor = value;
            }
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

        [Category("Custom Appearance")]
        public bool UnderlinedStyle
        {
            get => _underlinedStyle;
            set { _underlinedStyle = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        public Color BorderFocusColor
        {
            get => _borderFocusColor;
            set { _borderFocusColor = value; }
        }

        [Category("Custom Appearance")]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                if (value >= 0)
                {
                    _borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Custom Appearance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox.BackColor = value;
            }
        }

        [Category("Custom Appearance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox.ForeColor = value;
            }
        }

        [Category("Custom Appearance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox.Font = value;
            }
        }

        [Category("Custom Appearance")]
        public string Texts
        {
            get => _isPlaceholder ? "" : textBox.Text;
            set
            {
                textBox.Text = value;

                if (string.IsNullOrEmpty(value))
                {
                    SetPlaceholder(null, null);
                }
            }
        }

        [Category("Custom Appearance")]
        public bool Multiline
        {
            get => textBox.Multiline;
            set => textBox.Multiline = value;
        }

        [Category("Custom Appearance")]
        public bool PasswordChar
        {
            get => _isPasswordChar;
            set
            {
                _isPasswordChar = value;
                if (!_isPlaceholder)
                    textBox.UseSystemPasswordChar = value;
            }
        }

        [Category("Custom Appearance")]
        public ScrollBars ScrollBars
        {
            get => textBox.ScrollBars;
            set => textBox.ScrollBars = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color borderColor = _isFocused ? _borderFocusColor : _borderColor;

            using (GraphicsPath pathBorder = GetFigurePath(this.ClientRectangle, _borderRadius))
            using (Pen penBorder = new Pen(borderColor, _borderSize))
            {
                if (_underlinedStyle)
                {
                    g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else
                {
                    g.DrawPath(penBorder, pathBorder);
                }
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            if (radius <= 0)
            {
                path.AddRectangle(rect);
            }
            else
            {
                path.StartFigure();
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
                path.CloseFigure();
            }

            return path;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (_isPlaceholder)
            {
                _isPlaceholder = false;
                textBox.Text = "";
                textBox.ForeColor = this.ForeColor;
                textBox.UseSystemPasswordChar = _isPasswordChar; // restore password
            }
            _isFocused = true;
            this.Invalidate();
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) && !string.IsNullOrEmpty(_placeholderText))
            {
                _isPlaceholder = true;
                textBox.Text = _placeholderText;
                textBox.ForeColor = _placeholderColor;
                textBox.UseSystemPasswordChar = false; // placeholder always visible
            }
            _isFocused = false;
            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateControlRegion();
            }
        }

        private void UpdateControlRegion()
        {
            if (_borderRadius > 1)
            {
                using (GraphicsPath pathBorder = GetFigurePath(this.ClientRectangle, _borderRadius))
                {
                    this.Region = new Region(pathBorder);
                }
            }
            else this.Region = new Region(this.ClientRectangle);
        }

    }
}
