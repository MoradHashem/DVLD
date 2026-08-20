namespace DVLDPresentationLayer
{
    partial class ManagePeopleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeopleScreen));
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.ptrbManagePeople = new System.Windows.Forms.PictureBox();
            this.lblCountRecods = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvListPeople = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbManagePeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AutoSize = true;
            this.lblManagePeople.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblManagePeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManagePeople.Location = new System.Drawing.Point(629, 202);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(194, 29);
            this.lblManagePeople.TabIndex = 1;
            this.lblManagePeople.Text = "Manage People";
            this.lblManagePeople.UseWaitCursor = true;
            this.lblManagePeople.Click += new System.EventHandler(this.label1_Click);
            // 
            // ptrbManagePeople
            // 
            this.ptrbManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("ptrbManagePeople.Image")));
            this.ptrbManagePeople.Location = new System.Drawing.Point(623, -1);
            this.ptrbManagePeople.Name = "ptrbManagePeople";
            this.ptrbManagePeople.Size = new System.Drawing.Size(200, 200);
            this.ptrbManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbManagePeople.TabIndex = 2;
            this.ptrbManagePeople.TabStop = false;
            this.ptrbManagePeople.UseWaitCursor = true;
            // 
            // lblCountRecods
            // 
            this.lblCountRecods.AutoSize = true;
            this.lblCountRecods.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRecods.Location = new System.Drawing.Point(9, 843);
            this.lblCountRecods.Name = "lblCountRecods";
            this.lblCountRecods.Size = new System.Drawing.Size(103, 19);
            this.lblCountRecods.TabIndex = 3;
            this.lblCountRecods.Text = "# Records :";
            this.lblCountRecods.UseWaitCursor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(119, 845);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 19);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0";
            this.lblCount.UseWaitCursor = true;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(8, 210);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(93, 19);
            this.lblFilterBy.TabIndex = 5;
            this.lblFilterBy.Text = "Filter By : ";
            this.lblFilterBy.UseWaitCursor = true;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(96, 208);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(162, 24);
            this.cmbFilter.TabIndex = 6;
            this.cmbFilter.Text = "Nono";
            this.cmbFilter.UseWaitCursor = true;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.BackColor = System.Drawing.Color.White;
            this.btnAddPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.BackgroundImage")));
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Location = new System.Drawing.Point(1351, 203);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(67, 44);
            this.btnAddPerson.TabIndex = 7;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.UseWaitCursor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1288, 833);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvListPeople
            // 
            this.dgvListPeople.AllowUserToAddRows = false;
            this.dgvListPeople.AllowUserToDeleteRows = false;
            this.dgvListPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPeople.Location = new System.Drawing.Point(12, 253);
            this.dgvListPeople.Name = "dgvListPeople";
            this.dgvListPeople.ReadOnly = true;
            this.dgvListPeople.Size = new System.Drawing.Size(1406, 570);
            this.dgvListPeople.TabIndex = 0;
            this.dgvListPeople.UseWaitCursor = true;
            // 
            // ManagePeopleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1427, 881);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCountRecods);
            this.Controls.Add(this.ptrbManagePeople);
            this.Controls.Add(this.lblManagePeople);
            this.Controls.Add(this.dgvListPeople);
            this.Name = "ManagePeopleScreen";
            this.Text = "Manage People";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbManagePeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.PictureBox ptrbManagePeople;
        private System.Windows.Forms.Label lblCountRecods;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvListPeople;
    }
}