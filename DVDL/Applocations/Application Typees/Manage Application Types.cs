using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLDPresentationLayer
{
    public partial class frmManageApplicationTypes : Form
    {

        private static DataTable _dtAllApplicationTypes;

        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = clsApplicationTypes.ListApplicationTpyes();
            dgvListAplicationTypes.DataSource = _dtAllApplicationTypes;
            lblCount.Text = dgvListAplicationTypes.Rows.Count.ToString();


            if (_dtAllApplicationTypes.Rows.Count > 0)
            {
                dgvListAplicationTypes.Columns[0].HeaderText = "ID";
                dgvListAplicationTypes.Columns[0].Width = 120;

                dgvListAplicationTypes.Columns[1].HeaderText = "Title";
                dgvListAplicationTypes.Columns[1].Width = 372;

                dgvListAplicationTypes.Columns[2].HeaderText = "Fees";
                dgvListAplicationTypes.Columns[2].Width = 120;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void tsmiEditApplicationType_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = Convert.ToInt32(dgvListAplicationTypes.CurrentRow.Cells["ApplicationTypeID"].Value);

            frmUpdateApplicationType frm = new frmUpdateApplicationType(ApplicationTypeID);

            frm.ShowDialog();
            frmManageApplicationTypes_Load(null, null);
        }
    }
}
