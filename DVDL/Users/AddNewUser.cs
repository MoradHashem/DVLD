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
    public partial class frmAddEditNewUser : Form
    {
        
        public enum _enMode { AddNew = 0, Update = 1 };
        private _enMode _Mode;

        private clsUsers _User;
        private int _UserID;
        private int _PersonID = -1;


        private void _MakeMode(int UserID)
        {
            _UserID = UserID;

            if (_UserID == -1)
                _Mode = _enMode.AddNew;
            else
                _Mode = _enMode.Update;

            if (_Mode == _enMode.AddNew)
                lblTitle.Text = "Add New User";
            else
                lblTitle.Text = "Update User";

        }


        public frmAddEditNewUser()
        {
            InitializeComponent();
            
            usctrlFilter1.PersonFound += frmAddNewUser_PersonFound;
            
            _MakeMode(-1);

        }

        public frmAddEditNewUser(int UserID)
        {
            InitializeComponent();

            _MakeMode(UserID);

        }

        


        private void _LoadData()
        {


            if (_Mode == _enMode.AddNew)
            {
                _User = new clsUsers();

                return;
            }

            _User = clsUsers.FindUserByID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("This form will be closed because no User with " + _UserID);
                this.Close();

                return;
            }


            
            usctrlFilter1.SetPersonIDIntxtFind(_User.PersonID);
            usctrlFilter1.Enabled = false;
            usctrlPersonDetails1.LoadPersonInfo(_User.PersonID);
            lblUserIDValue.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            ckIsActive.Checked = _User.IsActive;
            _PersonID = _User.PersonID;


            _User.Mode = (clsUsers._enMode)_Mode;



        }

        private bool ValidateRequiredFields()
        {
            bool IsValid = true;

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                erpMessage.SetError(txtUserName, "User Name is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtUserName, "");
            }


            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                erpMessage.SetError(txtPassword, "Password is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtPassword, "");
            }


            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                erpMessage.SetError(txtConfirmPassword, "Confirm Password is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtConfirmPassword, "");
            }

            return IsValid;
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewUser_PersonFound(object sender, int PersonID)
        {
            usctrlPersonDetails1.LoadPersonInfo(PersonID);
            _PersonID = PersonID;
        }

        private void frmAddEditNewUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            tcAddNewUser.SelectedTab = tpLoginInfo;
        }

        private void tpLoginInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
            {
                MessageBox.Show("There is a Filed is not inputed, Please fill it.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            _User.PersonID = _PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtConfirmPassword.Text;
            _User.IsActive = ckIsActive.Checked;


            if (_User.Save())
            {
                lblUserIDValue.Text = _User.UserID.ToString();
                MessageBox.Show("Data save successfully.");
            }
            else
                MessageBox.Show("Error : Data is not saved succcessfully.");


            _Mode = _enMode.Update;
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
                erpMessage.SetError(txtUserName, "User Name is required.");

            else
                erpMessage.SetError(txtUserName, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                erpMessage.SetError(txtPassword, "Password is required.");
            else
                erpMessage.SetError(txtPassword, "");

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                erpMessage.SetError(txtConfirmPassword, "Confirm Password is required.");

            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                erpMessage.SetError(txtConfirmPassword, "Passwords do not match.");
                e.Cancel = true;
            }

            else
                erpMessage.SetError(txtConfirmPassword, "");

        }
    }
}
