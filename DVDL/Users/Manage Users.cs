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

        private static DataTable _dtAllUsers;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUsers.ListUsers();

            dgvListUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            lblCount.Text = dgvListUsers.Rows.Count.ToString();

            if (_dtAllUsers.Rows.Count > 0)
            {
                dgvListUsers.Columns[0].HeaderText = "User ID";
                dgvListUsers.Columns[0].Width = 80;

                dgvListUsers.Columns[1].HeaderText = "Person ID";
                dgvListUsers.Columns[1].Width = 100;

                dgvListUsers.Columns[2].HeaderText = "Full Name";
                dgvListUsers.Columns[2].Width = 280;

                dgvListUsers.Columns[3].HeaderText = "UserName";
                dgvListUsers.Columns[3].Width = 100;

                dgvListUsers.Columns[4].HeaderText = "Is Active";
                dgvListUsers.Columns[4].Width = 91;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilter.Visible = false;
                cbFilterIsActive.Visible = true;
                cbFilterIsActive.SelectedIndex = 0;
                cbFilterIsActive.Focus();
            }
            else
            {
                txtFilter.Visible = (cbFilterBy.Text != "None");
                cbFilterIsActive.Visible = false;

                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblCount.Text = dgvListUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());


            lblCount.Text = _dtAllUsers.Rows.Count.ToString();

        }

        private void cbFilterIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbFilterIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblCount.Text = dgvListUsers.RowCount.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditNewUser();

            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditNewUser();

            frm.ShowDialog();
            frmManageUsers_Load(null, null);

        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells["UserID"].Value);

            if (MessageBox.Show($"Are you sure you want to delete user [ {UserID} ]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUsers.DeleteUser(UserID))
                {
                    MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManageUsers_Load(null, null);
                }

                else
                    MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells["UserID"].Value;

            frmAddEditNewUser frm = new frmAddEditNewUser(UserID);

            frm.ShowDialog();
            frmManageUsers_Load(null, null);

        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)  
        {
            int UserID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells["UserID"].Value);

            frmUserInformation frm = new frmUserInformation(UserID);

            frm.ShowDialog();
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells["UserID"].Value);

            frmChangePassword frm = new frmChangePassword(UserID);

            frm.ShowDialog();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tsmiPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void tsmiSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvListUsers_DoubleClick(object sender, EventArgs e)
        {

            int UserID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells["UserID"].Value);

            frmUserInformation frm = new frmUserInformation(UserID);

            frm.ShowDialog();
        }
    }
}
