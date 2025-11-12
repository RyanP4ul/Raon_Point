using RaonPointWindowsForms.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Components
{
    public partial class MenuListItem : UserControl
    {

        private Action onClickAction;

        public MenuListItem()
        {
            InitializeComponent();
        }

        public void SetTitle(string title) => btnItem.Text = title;

        public void SetIcon(Image image)
        {
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Image = image;
        }

        public void SetOnClickAction(Action action)
        {
            onClickAction = action;
        }

        public void toggleActiveState(bool isActive)
        {
            if (isActive)
            {
                btnItem.ForeColor = Color.White;
                btnItem.BackColor = Color.FromArgb(180, 180, 0);
                btnItem.Font = new Font(btnItem.Font, FontStyle.Bold);
                pictureBox.BackColor = Color.FromArgb(214, 209, 0);
            }
            else
            {
                btnItem.ForeColor = Color.White;
                btnItem.BackColor = Color.FromArgb(50, 50, 50);
                btnItem.Font = new Font(btnItem.Font, FontStyle.Regular);
                pictureBox.BackColor = Color.Transparent;
            }
        }


        private void btnItem_Click(object sender, EventArgs e)
        {
            if (Main.CurrentMenuItem != null)
            {
                Main.CurrentMenuItem.toggleActiveState(false);
            }

            onClickAction?.Invoke();

            toggleActiveState(true);

            Main.CurrentMenuItem = this;
        }
    }
}
