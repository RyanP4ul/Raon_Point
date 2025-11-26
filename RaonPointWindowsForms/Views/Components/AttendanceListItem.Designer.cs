namespace RaonPointWindowsForms.Views.Components
{
    partial class AttendanceListItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.lblMemId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(26, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(154, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ryan Paul Espinola";
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInTime.ForeColor = System.Drawing.Color.Silver;
            this.lblCheckInTime.Location = new System.Drawing.Point(422, 23);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(52, 15);
            this.lblCheckInTime.TabIndex = 3;
            this.lblCheckInTime.Text = "8:00 AM";
            // 
            // lblMemId
            // 
            this.lblMemId.AutoSize = true;
            this.lblMemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemId.ForeColor = System.Drawing.Color.Silver;
            this.lblMemId.Location = new System.Drawing.Point(26, 34);
            this.lblMemId.Name = "lblMemId";
            this.lblMemId.Size = new System.Drawing.Size(29, 15);
            this.lblMemId.TabIndex = 4;
            this.lblMemId.Text = "M-1";
            // 
            // AttendanceListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblMemId);
            this.Controls.Add(this.lblCheckInTime);
            this.Controls.Add(this.lblName);
            this.Name = "AttendanceListItem";
            this.Size = new System.Drawing.Size(514, 64);
            this.Load += new System.EventHandler(this.AttendanceListItem_Load);
            this.Click += new System.EventHandler(this.AttendanceListItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.Label lblMemId;
    }
}
