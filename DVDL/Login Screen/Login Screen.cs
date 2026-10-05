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
    public partial class frmLoginScreen : Form
    {
        private clsUsers _User;


        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private bool _LoadData()
        {
            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("Please enter Username and Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            clsLoginInformation.UserName = txtUserName.Text;
            clsLoginInformation.Password = txtPassword.Text;


            _User = clsUsers.FindUserByUserName(clsLoginInformation.UserName);

            if (_User == null)
            {
                MessageBox.Show("Sorry no user with this Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_User.IsActive)
            {
                if ((_User.Password != txtPassword.Text) || (_User.UserName != txtUserName.Text))
                {
                    MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("This user is not active.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            if (clsLoginInformation.RememberMe)
            {
                txtPassword.Text = clsLoginInformation.Password;
                txtUserName.Text = clsLoginInformation.UserName;
                chkRememberMe.Checked = clsLoginInformation.RememberMe;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_LoadData())
            {
                Form frm = new MainScreen();


                frm.ShowDialog();

                this.Close();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            clsLoginInformation.UserName = txtUserName.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            clsLoginInformation.Password = txtPassword.Text;
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            clsLoginInformation.RememberMe = chkRememberMe.Checked;
        }
    }
}
