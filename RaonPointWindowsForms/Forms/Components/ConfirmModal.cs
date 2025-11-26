using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Forms.Components
{
    public partial class ConfirmModal : Form
    {

        private Action onYes;

        public ConfirmModal(Action onYes = null)
        {
            InitializeComponent();
            this.onYes = onYes;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            onYes?.Invoke();
            Close();
        }
    }
}
