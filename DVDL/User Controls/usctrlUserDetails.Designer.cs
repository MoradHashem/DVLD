namespace DVLDPresentationLayer
{
    partial class usctrlUserDetails
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
            this.gbLoginInformation = new System.Windows.Forms.GroupBox();
            this.lblIsActiveValue = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUserNameValue = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.usctrlPersonDetails1 = new DVLDPresentationLayer.usctrlPersonDetails();
            this.gbLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLoginInformation
            // 
            this.gbLoginInformation.Controls.Add(this.lblIsActiveValue);
            this.gbLoginInformation.Controls.Add(this.lblIsActive);
            this.gbLoginInformation.Controls.Add(this.lblUserNameValue);
            this.gbLoginInformation.Controls.Add(this.lblUserName);
            this.gbLoginInformation.Controls.Add(this.lblUserIDValue);
            this.gbLoginInformation.Controls.Add(this.lblUserID);
            this.gbLoginInformation.Location = new System.Drawing.Point(7, 317);
            this.gbLoginInformation.Name = "gbLoginInformation";
            this.gbLoginInformation.Size = new System.Drawing.Size(876, 81);
            this.gbLoginInformation.TabIndex = 48;
            this.gbLoginInformation.TabStop = false;
            this.gbLoginInformation.Text = "Login Information";
            // 
            // lblIsActiveValue
            // 
            this.lblIsActiveValue.AutoSize = true;
            this.lblIsActiveValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActiveValue.Location = new System.Drawing.Point(704, 32);
            this.lblIsActiveValue.Name = "lblIsActiveValue";
            this.lblIsActiveValue.Size = new System.Drawing.Size(35, 18);
            this.lblIsActiveValue.TabIndex = 45;
            this.lblIsActiveValue.Text = "???";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(605, 32);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(83, 18);
            this.lblIsActive.TabIndex = 44;
            this.lblIsActive.Text = "Is Active :";
            // 
            // lblUserNameValue
            // 
            this.lblUserNameValue.AutoSize = true;
            this.lblUserNameValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameValue.Location = new System.Drawing.Point(422, 32);
            this.lblUserNameValue.Name = "lblUserNameValue";
            this.lblUserNameValue.Size = new System.Drawing.Size(35, 18);
            this.lblUserNameValue.TabIndex = 43;
            this.lblUserNameValue.Text = "???";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(312, 32);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(95, 18);
            this.lblUserName.TabIndex = 42;
            this.lblUserName.Text = "UserName :";
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDValue.Location = new System.Drawing.Point(154, 32);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(35, 18);
            this.lblUserIDValue.TabIndex = 41;
            this.lblUserIDValue.Text = "???";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(64, 32);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(74, 18);
            this.lblUserID.TabIndex = 40;
            this.lblUserID.Text = "User ID :";
            // 
            // usctrlPersonDetails1
            // 
            this.usctrlPersonDetails1.BackColor = System.Drawing.Color.White;
            this.usctrlPersonDetails1.Location = new System.Drawing.Point(-2, -1);
            this.usctrlPersonDetails1.Name = "usctrlPersonDetails1";
            this.usctrlPersonDetails1.Size = new System.Drawing.Size(899, 320);
            this.usctrlPersonDetails1.TabIndex = 49;
            // 
            // usctrlUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.usctrlPersonDetails1);
            this.Controls.Add(this.gbLoginInformation);
            this.Name = "usctrlUserDetails";
            this.Size = new System.Drawing.Size(891, 410);
            this.gbLoginInformation.ResumeLayout(false);
            this.gbLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLoginInformation;
        private System.Windows.Forms.Label lblIsActiveValue;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUserNameValue;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lblUserID;
        private usctrlPersonDetails usctrlPersonDetails1;
    }
}
