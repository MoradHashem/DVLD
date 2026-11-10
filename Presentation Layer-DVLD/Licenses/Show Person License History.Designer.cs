namespace DVLDPresentationLayer.Licenses
{
    partial class frmShowPersonLicenseHistory
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
            this.usctrlPersonDetails1 = new DVLDPresentationLayer.usctrlPersonDetails();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptrEmail = new System.Windows.Forms.PictureBox();
            this.usctrlDriverLicenses1 = new DVLDPresentationLayer.User_Controls.usctrlDriverLicenses();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // usctrlPersonDetails1
            // 
            this.usctrlPersonDetails1.BackColor = System.Drawing.Color.White;
            this.usctrlPersonDetails1.Location = new System.Drawing.Point(270, 108);
            this.usctrlPersonDetails1.Name = "usctrlPersonDetails1";
            this.usctrlPersonDetails1.Size = new System.Drawing.Size(899, 320);
            this.usctrlPersonDetails1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(435, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 38);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "License History";
            // 
            // ptrEmail
            // 
            this.ptrEmail.Image = global::DVLDPresentationLayer.Properties.Resources.PersonLicenseHistory_512;
            this.ptrEmail.Location = new System.Drawing.Point(8, 181);
            this.ptrEmail.Margin = new System.Windows.Forms.Padding(4);
            this.ptrEmail.Name = "ptrEmail";
            this.ptrEmail.Size = new System.Drawing.Size(260, 220);
            this.ptrEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrEmail.TabIndex = 23;
            this.ptrEmail.TabStop = false;
            // 
            // usctrlDriverLicenses1
            // 
            this.usctrlDriverLicenses1.BackColor = System.Drawing.Color.White;
            this.usctrlDriverLicenses1.Location = new System.Drawing.Point(4, 419);
            this.usctrlDriverLicenses1.Name = "usctrlDriverLicenses1";
            this.usctrlDriverLicenses1.Size = new System.Drawing.Size(1157, 368);
            this.usctrlDriverLicenses1.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1013, 794);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 36);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 839);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.usctrlDriverLicenses1);
            this.Controls.Add(this.ptrEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.usctrlPersonDetails1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowPersonLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Person License History";
            this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private usctrlPersonDetails usctrlPersonDetails1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox ptrEmail;
        private User_Controls.usctrlDriverLicenses usctrlDriverLicenses1;
        private System.Windows.Forms.Button btnClose;
    }
}