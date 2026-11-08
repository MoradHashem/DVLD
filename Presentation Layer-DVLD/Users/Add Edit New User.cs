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
        
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private clsUsers _User;
        private int _UserID;

        public frmAddEditNewUser()
        {
            InitializeComponent();
            
            _Mode = enMode.AddNew;

        }

        public frmAddEditNewUser(int UserID) 
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;

        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                _User = new clsUsers();
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";

                tpLoginInfo.Enabled = false;

                usctrlPersonDetailsWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                tpLoginInfo.Enabled = true;
                btnNext.Enabled = true;
            }


            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            ckIsActive.Checked = true;
        }

        private void _LoadData()
        { 
            usctrlPersonDetailsWithFilter1.FilterEnabled = false;


            _User = clsUsers.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }


            
            lblUserIDValue.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            ckIsActive.Checked = _User.IsActive;
            usctrlPersonDetailsWithFilter1.LoadPersonInfo(_User.PersonID);

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

        private void frmAddEditNewUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;

                tcUserInfo.SelectedTab = tpLoginInfo;
                return; 
            }


            if (usctrlPersonDetailsWithFilter1.PersonID != -1)
            {

                if (clsUsers.IsUserExistForPersonID(usctrlPersonDetailsWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usctrlPersonDetailsWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                }
            }

            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usctrlPersonDetailsWithFilter1.FilterFocus();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = usctrlPersonDetailsWithFilter1.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = ckIsActive.Checked;


            if (_User.Save())
            {
                lblUserIDValue.Text = _User.UserID.ToString();
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                _Mode = enMode.Update;
                MessageBox.Show("Data save successfully.");
            }
            else
                MessageBox.Show("Error : Data is not saved succcessfully.");


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
                erpMessage.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
                e.Cancel = true;
            }

            else
                erpMessage.SetError(txtConfirmPassword, "");

        }

        private void frmAddEditNewUser_Activated(object sender, EventArgs e)
        {
            usctrlPersonDetailsWithFilter1.FilterFocus();
        }
    }
}
