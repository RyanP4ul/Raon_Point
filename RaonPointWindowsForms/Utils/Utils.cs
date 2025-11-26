using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Utils
{
    public static class Utils
    {

        public static void ShowModal(Form form, UserControl modal)
        {
            modal.Left = (form.ClientSize.Width - modal.Width) / 2;
            modal.Top = (form.ClientSize.Height - modal.Height) / 2;
            form.Controls.Add(modal);
            modal.BringToFront();
        }

        public static DateTime GetExpirationDate(string plan)
        {
            DateTime now = DateTime.Now;

            switch (plan)
            {
                case "Starter":
                    return now.AddMonths(1);
                case "Challenger":
                    return now.AddMonths(3);
                case "Performer":
                    return now.AddMonths(6);
                case "Transformer":
                    return now.AddYears(1);
                default:
                    return now;
            }
        }

        public static Form OverlayForm(Form parent) => new Form
        {
            StartPosition = FormStartPosition.Manual,
            ShowInTaskbar = false,
            FormBorderStyle = FormBorderStyle.None,
            BackColor = Color.Black,
            Opacity = 0.5,
            Size = parent.Size,
            Location = parent.Location,
            Owner = parent
        };

    }
}
