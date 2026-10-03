namespace DVLDPresentationLayer
{
    partial class frmAddEditPersonInfo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.ptrNationalNo = new System.Windows.Forms.PictureBox();
            this.usctrlAddEditPersonInfo1 = new DVLDPresentationLayer.usctrlAddEditPersonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.ptrNationalNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(332, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New Person";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(13, 84);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(91, 18);
            this.lblPersonID.TabIndex = 2;
            this.lblPersonID.Text = "Person ID :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(149, 86);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 18);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "N/A";
            // 
            // ptrNationalNo
            // 
            this.ptrNationalNo.Image = global::DVLDPresentationLayer.Properties.Resources.Number_32;
            this.ptrNationalNo.Location = new System.Drawing.Point(112, 84);
            this.ptrNationalNo.Margin = new System.Windows.Forms.Padding(4);
            this.ptrNationalNo.Name = "ptrNationalNo";
            this.ptrNationalNo.Size = new System.Drawing.Size(22, 23);
            this.ptrNationalNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrNationalNo.TabIndex = 10;
            this.ptrNationalNo.TabStop = false;
            // 
            // usctrlAddEditPersonInfo1
            // 
            this.usctrlAddEditPersonInfo1.BackColor = System.Drawing.Color.White;
            this.usctrlAddEditPersonInfo1.Location = new System.Drawing.Point(16, 108);
            this.usctrlAddEditPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.usctrlAddEditPersonInfo1.Name = "usctrlAddEditPersonInfo1";
            this.usctrlAddEditPersonInfo1.Size = new System.Drawing.Size(891, 407);
            this.usctrlAddEditPersonInfo1.TabIndex = 11;
            // 
            // frmAddEditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 517);
            this.Controls.Add(this.usctrlAddEditPersonInfo1);
            this.Controls.Add(this.ptrNationalNo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Person Info";
            this.Load += new System.EventHandler(this.frmAddEditPersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrNationalNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox ptrNationalNo;
        private usctrlAddEditPersonInfo usctrlAddEditPersonInfo1;
    }
}