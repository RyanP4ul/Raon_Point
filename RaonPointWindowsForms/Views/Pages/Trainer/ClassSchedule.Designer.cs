namespace RaonPointWindowsForms.Views.Pages.Trainer
{
    partial class ClassSchedule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTable = new System.Windows.Forms.Panel();
            this.roundedBorderedButton1 = new RaonPointWindowsForms.Views.Components.RoundedBorderedButton();
            this.SuspendLayout();
            // 
            // panelTable
            // 
            this.panelTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelTable.Location = new System.Drawing.Point(21, 63);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(1016, 522);
            this.panelTable.TabIndex = 5;
            // 
            // roundedBorderedButton1
            // 
            this.roundedBorderedButton1.BackColor = System.Drawing.Color.DarkKhaki;
            this.roundedBorderedButton1.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.roundedBorderedButton1.BorderRadius = 5;
            this.roundedBorderedButton1.BorderThickness = 2;
            this.roundedBorderedButton1.FlatAppearance.BorderSize = 0;
            this.roundedBorderedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedBorderedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedBorderedButton1.Location = new System.Drawing.Point(905, 17);
            this.roundedBorderedButton1.Name = "roundedBorderedButton1";
            this.roundedBorderedButton1.Size = new System.Drawing.Size(132, 31);
            this.roundedBorderedButton1.TabIndex = 6;
            this.roundedBorderedButton1.Text = "Create Schedule";
            this.roundedBorderedButton1.UseVisualStyleBackColor = false;
            this.roundedBorderedButton1.Click += new System.EventHandler(this.roundedBorderedButton1_Click);
            // 
            // ClassSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.roundedBorderedButton1);
            this.Controls.Add(this.panelTable);
            this.Name = "ClassSchedule";
            this.Size = new System.Drawing.Size(1063, 606);
            this.Load += new System.EventHandler(this.ClassSchedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTable;
        private Components.RoundedBorderedButton roundedBorderedButton1;
    }
}
