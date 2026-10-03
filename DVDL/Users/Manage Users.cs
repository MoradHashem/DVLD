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
    public partial class frmManageUsers : Form
    {

        private DataTable _Users;

        public frmManageUsers()
        {
            InitializeComponent();
            _RefrashUsersList();
        }

        
        private void _RefrashUsersList()
        {
            _Users = clsUsers.ListUsers();

            dgvListUsers.DataSource = _Users;

            dgvListUsers.Columns.Remove("Is Active");

            DataGridViewCheckBoxColumn chkIsActive = new DataGridViewCheckBoxColumn();
            chkIsActive.Name = "Is Active";
            chkIsActive.HeaderText = "Is Active";
            chkIsActive.DataPropertyName = "Is Active";

            dgvListUsers.Columns.Add(chkIsActive);

            lblCount.Text = dgvListUsers.RowCount.ToString();
            dgvListUsers.Columns["Full Name"].Width = 250;
        }


        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefrashUsersList();

            txtFilter.Visible = false;
            cmbFilterIsActive.Visible = false;
            combFilterBy.SelectedItem = "None";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combFilterBy.Text == "None")
            {
                txtFilter.Visible = false;
                cmbFilterIsActive.Visible = false;
                _RefrashUsersList();
            }
            else if (combFilterBy.Text == "Is Active")
            {
                cmbFilterIsActive.Visible = true;
                cmbFilterIsActive.SelectedIndex = 0;
                txtFilter.Visible = false;
                cmbFilterIsActive.Focus();
            }
            else
            {
                cmbFilterIsActive.Visible = false;
                txtFilter.Visible = true;
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterValue = txtFilter.Text.Trim();

            if (_Users == null)
                return;

            DataView dvUsers = _Users.DefaultView;


            switch (combFilterBy.Text)
            {
                case "Person ID":

                    if (int.TryParse(FilterValue, out int PersonID))
                        dvUsers.RowFilter = $"[Person ID] = {PersonID}";

                    break;

                case "User ID":

                    if (int.TryParse(FilterValue, out int UserID))
                        dvUsers.RowFilter = $"[User ID] = {UserID}";

                    break;

                case "Full Name":

                    dvUsers.RowFilter = $"[Full Name] LIKE '{FilterValue}%'";

                    break;

                case "User Name":

                    dvUsers.RowFilter = $"[User Name] LIKE '{FilterValue}%'";

                    break;
                
                default:

                    dvUsers.RowFilter = "";

                    break;
            }

            dgvListUsers.DataSource = dvUsers;

            lblCount.Text = dgvListUsers.RowCount.ToString();
        }

        private void cmbFilterIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Users == null)
                return;

            DataView dvUsers = _Users.DefaultView;

            switch (cmbFilterIsActive.Text)
            {
                case "All":

                    dvUsers.RowFilter = "";
                    break;

                case "Yes":

                    dvUsers.RowFilter = "[Is Active] = true";
                    break;

                case "No":

                    dvUsers.RowFilter = "[Is Active] = false";
                    break;
            }

            dgvListUsers.DataSource = dvUsers;

            lblCount.Text = dgvListUsers.RowCount.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditNewUser();

            frm.ShowDialog();
            _RefrashUsersList();
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditNewUser();

            frm.ShowDialog();
            _RefrashUsersList();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells["User ID"].Value);

            if (MessageBox.Show($"Are you sure you want to delete user [ {UserID} ]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUsers.DeleteUser(UserID))
                    MessageBox.Show("User Deleted Successfully.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _RefrashUsersList();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells["User ID"].Value);

            frmAddEditNewUser frm = new frmAddEditNewUser(UserID);

            frm.ShowDialog();
            _RefrashUsersList();
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells["User ID"].Value);
            int PersonID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells["Person ID"].Value);

            frmUserInformation frm = new frmUserInformation(UserID, PersonID);

            frm.ShowDialog();
        }
    }
}
