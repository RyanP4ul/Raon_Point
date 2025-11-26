namespace RaonPointWindowsForms.Views.Components
{
    partial class RecentHistoryListItem
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
            this.lblAction = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAction
            // 
            this.lblAction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAction.Location = new System.Drawing.Point(207, 8);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(179, 23);
            this.lblAction.TabIndex = 4;
            this.lblAction.Text = "Check-In";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUser.Location = new System.Drawing.Point(24, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(177, 23);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Ryan Paul";
            // 
            // RecentHistoryListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblUser);
            this.Name = "RecentHistoryListItem";
            this.Size = new System.Drawing.Size(488, 38);
            this.Load += new System.EventHandler(this.RecentHistoryListItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblUser;
    }
}
