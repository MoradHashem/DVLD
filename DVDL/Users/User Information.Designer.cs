namespace DVLDPresentationLayer
{
    partial class frmUserInformation
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
            this.btnClose = new System.Windows.Forms.Button();
            this.usctrlPersonDetails1 = new DVLDPresentationLayer.usctrlPersonDetails();
            this.usctrlLoginInformation1 = new DVLDPresentationLayer.usctrlLoginInformation();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_321;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(763, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 46);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // usctrlPersonDetails1
            // 
            this.usctrlPersonDetails1.BackColor = System.Drawing.Color.White;
            this.usctrlPersonDetails1.Location = new System.Drawing.Point(23, 22);
            this.usctrlPersonDetails1.Name = "usctrlPersonDetails1";
            this.usctrlPersonDetails1.Size = new System.Drawing.Size(899, 320);
            this.usctrlPersonDetails1.TabIndex = 1;
            // 
            // usctrlLoginInformation1
            // 
            this.usctrlLoginInformation1.BackColor = System.Drawing.Color.White;
            this.usctrlLoginInformation1.Location = new System.Drawing.Point(31, 335);
            this.usctrlLoginInformation1.Name = "usctrlLoginInformation1";
            this.usctrlLoginInformation1.Size = new System.Drawing.Size(891, 92);
            this.usctrlLoginInformation1.TabIndex = 0;
            // 
            // frmUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 485);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.usctrlPersonDetails1);
            this.Controls.Add(this.usctrlLoginInformation1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.User_Information_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private usctrlLoginInformation usctrlLoginInformation1;
        private usctrlPersonDetails usctrlPersonDetails1;
        private System.Windows.Forms.Button btnClose;
    }
}