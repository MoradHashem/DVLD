namespace DVLDPresentationLayer.User_Controls
{
    partial class usctrlDriverLicenseInfoWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.usctrlDriverLicenseInfo1 = new DVLDPresentationLayer.User_Controls.usctrlDriverLicenseInfo();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(21, 27);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(96, 18);
            this.lblLicenseID.TabIndex = 68;
            this.lblLicenseID.Text = "License ID :";
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point(123, 27);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(230, 24);
            this.txtLicenseID.TabIndex = 69;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
            this.txtLicenseID.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseID_Validating);
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Image = global::DVLDPresentationLayer.Properties.Resources.License_View_32;
            this.btnFind.Location = new System.Drawing.Point(377, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(62, 40);
            this.btnFind.TabIndex = 70;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.txtLicenseID);
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.lblLicenseID);
            this.gbFilters.Location = new System.Drawing.Point(15, 3);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(453, 70);
            this.gbFilters.TabIndex = 71;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // usctrlDriverLicenseInfo1
            // 
            this.usctrlDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.usctrlDriverLicenseInfo1.Location = new System.Drawing.Point(13, 74);
            this.usctrlDriverLicenseInfo1.Name = "usctrlDriverLicenseInfo1";
            this.usctrlDriverLicenseInfo1.Size = new System.Drawing.Size(1013, 348);
            this.usctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // usctrlDriverLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.usctrlDriverLicenseInfo1);
            this.Name = "usctrlDriverLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(1031, 382);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private usctrlDriverLicenseInfo usctrlDriverLicenseInfo1;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
