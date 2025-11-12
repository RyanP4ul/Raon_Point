using RaonPointWindowsForms.Utils;
using RaonPointWindowsForms.Views.Components.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaonPointWindowsForms.Views.Pages.Trainer
{
    [ToolboxItem(false)]
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Modal.ShowModal(ParentForm, new RegistrationSuccessModal());
        }
    }
}
