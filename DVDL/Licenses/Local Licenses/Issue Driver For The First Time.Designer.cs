namespace DVLDPresentationLayer.Licenses.Local_Licenses
{
    partial class frmIssueDriverForTheFirstTime
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usctrlLocalDrivingLicenseApplicationInfo1 = new DVLDPresentationLayer.User_Controls.usctrlLocalDrivingLicenseApplicationInfo();
            this.brnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // usctrlLocalDrivingLicenseApplicationInfo1
            // 
            this.usctrlLocalDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.usctrlLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 28);
            this.usctrlLocalDrivingLicenseApplicationInfo1.Name = "usctrlLocalDrivingLicenseApplicationInfo1";
            this.usctrlLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(904, 410);
            this.usctrlLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // brnClose
            // 
            this.brnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnClose.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_32;
            this.brnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnClose.Location = new System.Drawing.Point(586, 613);
            this.brnClose.Name = "brnClose";
            this.brnClose.Size = new System.Drawing.Size(162, 42);
            this.brnClose.TabIndex = 85;
            this.brnClose.Text = "Close";
            this.brnClose.UseVisualStyleBackColor = true;
            // 
            // btnIssue
            // 
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLDPresentationLayer.Properties.Resources.Lost_Driving_License_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(754, 613);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(162, 42);
            this.btnIssue.TabIndex = 84;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(147, 444);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(769, 153);
            this.txtNotes.TabIndex = 83;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLDPresentationLayer.Properties.Resources.Notes_32;
            this.pictureBox6.Location = new System.Drawing.Point(90, 444);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 82;
            this.pictureBox6.TabStop = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(12, 449);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(61, 18);
            this.lblNotes.TabIndex = 81;
            this.lblNotes.Text = "Notes :";
            // 
            // frmIssueDriverForTheFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 676);
            this.Controls.Add(this.brnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.usctrlLocalDrivingLicenseApplicationInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssueDriverForTheFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driver For The First Time.cs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.usctrlLocalDrivingLicenseApplicationInfo usctrlLocalDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Button brnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblNotes;
    }
}