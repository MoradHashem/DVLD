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

        public frmChangePassword(int UserID)
        {
            
            InitializeComponent();
            
            _UserID = UserID;

        }

        private void _ResetDefualtValues()
        {
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _User = clsUsers.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("Could not Find User with id = " + _UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;

            }


            usctrlUserDetails1.LoadUserInfo(_UserID);
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
                erpMessage.SetError(txtCurrentPassword, "Current password is wrong!");
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
                erpMessage.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
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
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtNewPassword.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
                erpMessage.SetError(txtCurrentPassword, "Current Password is required.");

            else if (txtCurrentPassword.Text != _User.Password)
            {
                erpMessage.SetError(txtCurrentPassword, "Current password is wrong!");
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
                erpMessage.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
            }

            else
                erpMessage.SetError(txtConfirmPassword, "");
        }

    }
}
