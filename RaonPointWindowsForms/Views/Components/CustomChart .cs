using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RaonPointWindowsForms.Views.Components
{
    public class CustomChart : Chart
    {

        public Color LineColor { get; set; } = Color.FromArgb(0, 120, 215);
        public Color GridColor { get; set; } = Color.LightGray;
        public Color ChartBackColor { get; set; } = Color.White;
        public int LineWidth { get; set; } = 3;

        public CustomChart()
        {
            this.BackColor = Color.Transparent;

            ChartArea area;

            // If designer added ChartAreas, reuse the first
            if (this.ChartAreas.Count == 0)
            {
                area = new ChartArea("main");
                this.ChartAreas.Add(area);
            }
            else
            {
                area = this.ChartAreas[0];
                area.Name = "main";  // optional, remove if designer uses different name
            }

            area.BackColor = ChartBackColor;
            area.AxisX.MajorGrid.LineColor = GridColor;
            area.AxisY.MajorGrid.LineColor = GridColor;
            area.AxisX.LineWidth = 0;
            area.AxisY.LineWidth = 0;

            // Avoid duplicate series
            if (this.Series.IndexOf("data") == -1)
            {
                var series = new Series("data");
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = LineWidth;
                series.Color = LineColor;
                series.ChartArea = area.Name;
                this.Series.Add(series);
            }
        }


        //public CustomChart()
        //{
        //    this.BackColor = Color.Transparent;
        //    this.ChartAreas.Add(new ChartArea("main"));

        //    var area = this.ChartAreas["main"];
        //    area.BackColor = ChartBackColor;

        //    area.AxisX.MajorGrid.LineColor = GridColor;
        //    area.AxisY.MajorGrid.LineColor = GridColor;

        //    area.AxisX.LineWidth = 0;
        //    area.AxisY.LineWidth = 0;

        //    // Smooth curves
        //    var series = new Series("data");
        //    series.ChartType = SeriesChartType.Line;
        //    series.BorderWidth = LineWidth;
        //    series.Color = LineColor;
        //    series.BorderDashStyle = ChartDashStyle.Solid;
        //    series.MarkerSize = 0;
        //    series.ChartArea = "main";

        //    this.Series.Add(series);
        //}

        public void SetData(params double[] values)
        {
            this.Series["data"].Points.Clear();

            for (int i = 0; i < values.Length; i++)
                this.Series["data"].Points.AddXY(i + 1, values[i]);

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Optional: draw rounded border
            int radius = 20;
            using (GraphicsPath path = RoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), radius))
            using (Pen pen = new Pen(Color.LightGray, 2))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.Left, bounds.Top, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Top, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}
