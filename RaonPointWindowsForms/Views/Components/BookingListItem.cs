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
    public partial class BookingListItem : UserControl
    {

        private string full_name;

        public BookingListItem(string full_name)
        {
            InitializeComponent();
            this.full_name = full_name;
        }

        private void BookingListItem_Load(object sender, EventArgs e)
        {
            lblName.Text = full_name;
        }
    }
}
