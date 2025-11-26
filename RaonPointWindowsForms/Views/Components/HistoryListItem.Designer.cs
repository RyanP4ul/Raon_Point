namespace RaonPointWindowsForms.Views.Components
{
    partial class HistoryListItem
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
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCreatedDate.Location = new System.Drawing.Point(22, 20);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(166, 19);
            this.lblCreatedDate.TabIndex = 0;
            this.lblCreatedDate.Text = "11/25/2025, 7:01:59 PM";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUser.Location = new System.Drawing.Point(253, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(177, 23);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Ryan Paul";
            // 
            // lblAction
            // 
            this.lblAction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAction.Location = new System.Drawing.Point(436, 20);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(179, 23);
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "Check-In";
            this.lblAction.Click += new System.EventHandler(this.lblAction_Click_1);
            // 
            // lblDetails
            // 
            this.lblDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetails.Location = new System.Drawing.Point(621, 9);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(343, 38);
            this.lblDetails.TabIndex = 3;
            this.lblDetails.Text = "Check-In";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HistoryListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblCreatedDate);
            this.Name = "HistoryListItem";
            this.Size = new System.Drawing.Size(979, 58);
            this.Load += new System.EventHandler(this.HistoryListItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblDetails;
    }
}
