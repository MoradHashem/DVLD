namespace DVLDPresentationLayer.User_Controls
{
    partial class usctrlDriverLicenses
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
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblLocalCounts = new System.Windows.Forms.Label();
            this.llRecords = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.tpInternational = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblInternationalCounts = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblInternational = new System.Windows.Forms.Label();
            this.gbDriverLicenses.SuspendLayout();
            this.tcDriverLicenses.SuspendLayout();
            this.tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.tcDriverLicenses);
            this.gbDriverLicenses.Location = new System.Drawing.Point(3, 3);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(1151, 362);
            this.gbDriverLicenses.TabIndex = 0;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.Controls.Add(this.tpLocal);
            this.tcDriverLicenses.Controls.Add(this.tpInternational);
            this.tcDriverLicenses.Location = new System.Drawing.Point(16, 23);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(1129, 323);
            this.tcDriverLicenses.TabIndex = 0;
            // 
            // tpLocal
            // 
            this.tpLocal.BackColor = System.Drawing.Color.White;
            this.tpLocal.Controls.Add(this.dataGridView1);
            this.tpLocal.Controls.Add(this.lblLocalCounts);
            this.tpLocal.Controls.Add(this.llRecords);
            this.tpLocal.Controls.Add(this.lblLocal);
            this.tpLocal.Location = new System.Drawing.Point(4, 25);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(1121, 294);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "Local";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 207);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblLocalCounts
            // 
            this.lblLocalCounts.AutoSize = true;
            this.lblLocalCounts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalCounts.Location = new System.Drawing.Point(116, 259);
            this.lblLocalCounts.Name = "lblLocalCounts";
            this.lblLocalCounts.Size = new System.Drawing.Size(18, 18);
            this.lblLocalCounts.TabIndex = 2;
            this.lblLocalCounts.Text = "0";
            // 
            // llRecords
            // 
            this.llRecords.AutoSize = true;
            this.llRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRecords.Location = new System.Drawing.Point(16, 259);
            this.llRecords.Name = "llRecords";
            this.llRecords.Size = new System.Drawing.Size(94, 18);
            this.llRecords.TabIndex = 1;
            this.llRecords.Text = "# Records :";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(16, 21);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(176, 18);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "Local Licenses History";
            // 
            // tpInternational
            // 
            this.tpInternational.BackColor = System.Drawing.Color.White;
            this.tpInternational.Controls.Add(this.dataGridView2);
            this.tpInternational.Controls.Add(this.lblInternationalCounts);
            this.tpInternational.Controls.Add(this.lblRecords);
            this.tpInternational.Controls.Add(this.lblInternational);
            this.tpInternational.Location = new System.Drawing.Point(4, 25);
            this.tpInternational.Name = "tpInternational";
            this.tpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternational.Size = new System.Drawing.Size(1121, 294);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.Size = new System.Drawing.Size(1085, 207);
            this.dataGridView2.TabIndex = 7;
            // 
            // lblInternationalCounts
            // 
            this.lblInternationalCounts.AutoSize = true;
            this.lblInternationalCounts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalCounts.Location = new System.Drawing.Point(116, 259);
            this.lblInternationalCounts.Name = "lblInternationalCounts";
            this.lblInternationalCounts.Size = new System.Drawing.Size(18, 18);
            this.lblInternationalCounts.TabIndex = 6;
            this.lblInternationalCounts.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(16, 259);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(94, 18);
            this.lblRecords.TabIndex = 5;
            this.lblRecords.Text = "# Records :";
            // 
            // lblInternational
            // 
            this.lblInternational.AutoSize = true;
            this.lblInternational.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternational.Location = new System.Drawing.Point(16, 21);
            this.lblInternational.Name = "lblInternational";
            this.lblInternational.Size = new System.Drawing.Size(235, 18);
            this.lblInternational.TabIndex = 4;
            this.lblInternational.Text = "International Licenses History";
            // 
            // usctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDriverLicenses);
            this.Name = "usctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1157, 368);
            this.gbDriverLicenses.ResumeLayout(false);
            this.tcDriverLicenses.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            this.tpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpInternational.ResumeLayout(false);
            this.tpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.Label lblLocalCounts;
        private System.Windows.Forms.Label llRecords;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblInternationalCounts;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblInternational;
    }
}
