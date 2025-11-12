using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Components.Modals
{
    public partial class RegistrationSuccessModal : UserControl
    {

        public event EventHandler ModalClosed;

        public RegistrationSuccessModal()
        {
            InitializeComponent();
        }


        private void pbClose_Click(object sender, EventArgs e)
        {
            ModalClosed?.Invoke(this, EventArgs.Empty);
        }

        private void RegistrationSuccessModal_Load(object sender, EventArgs e)
        {

        }

        private void transparentPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
