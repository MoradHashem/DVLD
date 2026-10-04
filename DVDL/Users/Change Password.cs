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
    public partial class frmChangePassword : Form
    {
        private clsUsers _User;
        private int _UserID;
        private int _PersonID;

        public frmChangePassword()
        {
            InitializeComponent();
        }


        public frmChangePassword(int UserID, int PersonID)
        {
            InitializeComponent();

            _UserID = UserID;
            _PersonID = PersonID;
            _LoadData();

        }


        private void _LoadData()
        {
            usctrlLoginInformation1.LoadUserInfo(_UserID);
            usctrlPersonDetails1.LoadPersonInfo(_PersonID);

            _User = clsUsers.FindUserByID(_UserID);

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if (_UserID <= 0)
                return;

            _LoadData();
        }


        private bool ValidateRequiredFields()
        {
            bool IsValid = true;

            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                erpMessage.SetError(txtCurrentPassword, "Current Password is required.");
                IsValid = false;
            }

            else if (txtCurrentPassword.Text != _User.Password)
            {
                erpMessage.SetError(txtCurrentPassword, "Does not match Current Password");
                IsValid = false;
            }

            else
                erpMessage.SetError(txtCurrentPassword, "");
        


            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                erpMessage.SetError(txtNewPassword, "New Password is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtNewPassword, "");
            }



            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                erpMessage.SetError(txtConfirmPassword, "Confirm Password is required.");
                IsValid = false;
            }

            else if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                erpMessage.SetError(txtConfirmPassword, "Passwords do not match.");
                IsValid = false;
            }

            else
                erpMessage.SetError(txtConfirmPassword, "");



            return IsValid;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateRequiredFields())
            {
                MessageBox.Show("There is a Filed is not inputed, Please fill it.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            if (_User == null)
            {
                MessageBox.Show("This form will be closed because no User with " + _UserID);
                this.Close();

                return;
            }


            _User.Password = txtConfirmPassword.Text;

            if(_User.Save())
                MessageBox.Show("Data save successfully.");

            else
                MessageBox.Show("Error : Data is not saved succcessfully.");

        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
                erpMessage.SetError(txtCurrentPassword, "Current Password is required.");

            else if (txtCurrentPassword.Text != _User.Password)
            {
                erpMessage.SetError(txtCurrentPassword, "Does not match Current Password");
            }

            else
                erpMessage.SetError(txtCurrentPassword, "");
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
                erpMessage.SetError(txtNewPassword, "New Password is required.");

            else
                erpMessage.SetError(txtNewPassword, "");
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                erpMessage.SetError(txtConfirmPassword, "Confirm Password is required.");

            else if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                erpMessage.SetError(txtConfirmPassword, "Passwords do not match.");
            }

            else
                erpMessage.SetError(txtConfirmPassword, "");
        }
    }
}
