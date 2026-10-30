namespace DVLDPresentationLayer.Test
{
    partial class frmScheduleTest
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
            this.brnClose = new System.Windows.Forms.Button();
            this.usctrlScheduleTest1 = new DVLDPresentationLayer.User_Controls.usctrlScheduleTest();
            this.SuspendLayout();
            // 
            // brnClose
            // 
            this.brnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnClose.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_32;
            this.brnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnClose.Location = new System.Drawing.Point(253, 809);
            this.brnClose.Name = "brnClose";
            this.brnClose.Size = new System.Drawing.Size(162, 42);
            this.brnClose.TabIndex = 72;
            this.brnClose.Text = "Close";
            this.brnClose.UseVisualStyleBackColor = true;
            // 
            // usctrlScheduleTest1
            // 
            this.usctrlScheduleTest1.BackColor = System.Drawing.Color.White;
            this.usctrlScheduleTest1.Location = new System.Drawing.Point(9, 9);
            this.usctrlScheduleTest1.Name = "usctrlScheduleTest1";
            this.usctrlScheduleTest1.Size = new System.Drawing.Size(660, 794);
            this.usctrlScheduleTest1.TabIndex = 73;
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 871);
            this.Controls.Add(this.usctrlScheduleTest1);
            this.Controls.Add(this.brnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Test";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button brnClose;
        private User_Controls.usctrlScheduleTest usctrlScheduleTest1;
    }
}