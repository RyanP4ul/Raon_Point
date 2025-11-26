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
    public partial class Approved : Form
    {

        private Action<string, DateTime> onApproved;
        private string selected = null;

        public Approved(Action<string, DateTime> onApproved)
        {
            InitializeComponent();
            this.onApproved = onApproved;
        }

        private void Approved_Load(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selected))
            {
                MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            onApproved?.Invoke(selected, Utils.Utils.GetExpirationDate(selected));

            Close();
        }


        private void ResetButtons()
        {
            btnStarter.Text = "Select";
            btnChallenger.Text = "Select";
            btnPerformer.Text = "Select";
            btnTransformer.Text = "Select";

            btnStarter.Enabled = true;
            btnChallenger.Enabled = true;
            btnPerformer.Enabled = true;
            btnTransformer.Enabled = true;
        }

        private void btnStarter_Click(object sender, EventArgs e)
        {
            if (selected == "Starter")
            {
                ResetButtons();
                selected = null;
                return;
            }

            selected = "Starter";
            btnStarter.Text = "✓ Starter";
            btnStarter.Enabled = true;
            btnChallenger.Enabled = false;
            btnPerformer.Enabled = false;
            btnTransformer.Enabled = false;
        }

        private void btnChallenger_Click(object sender, EventArgs e)
        {
            if (selected == "Challenger")
            {
                ResetButtons();
                selected = null;
                return;
            }

            selected = "Challenger";

            btnChallenger.Text = "✓ Challenger";
            btnStarter.Enabled = false;
            btnChallenger.Enabled = true;
            btnPerformer.Enabled = false;
            btnTransformer.Enabled = false;
        }

        private void btnPerformer_Click(object sender, EventArgs e)
        {
            if (selected == "Performer")
            {
                ResetButtons();
                selected = null;
                return;
            }

            selected = "Performer";

            btnPerformer.Text = "✓ Performer";
            btnStarter.Enabled = false;
            btnChallenger.Enabled = false;
            btnPerformer.Enabled = true;
            btnTransformer.Enabled = false;
        }

        private void btnTransformer_Click(object sender, EventArgs e)
        {
            if (selected == "Transformer")
            {
                ResetButtons();
                selected = null;
                return;
            }

            selected = "Transformer";

            btnTransformer.Text = "✓ Transformer";
            btnStarter.Enabled = false;
            btnChallenger.Enabled = false;
            btnPerformer.Enabled = false;
            btnTransformer.Enabled = true;
        }

    }
}
