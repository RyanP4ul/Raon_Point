using System.Windows.Forms;

namespace RaonPointWindowsForms.Utils
{
    public static class Modal
    {

        public static void ShowModal(Form form, UserControl modal)
        {
            modal.Left = (form.ClientSize.Width - modal.Width) / 2;
            modal.Top = (form.ClientSize.Height - modal.Height) / 2;
            form.Controls.Add(modal);
            modal.BringToFront();
        }


    }
}
