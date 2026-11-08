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
    public partial class usctrlUserDetails : UserControl
    {
        private int _UserID = -1;
        private clsUsers _User;

        public int UserID
        {
            get { return _UserID; }
        }


        public void LoadUserInfo(int UserID)
        {
            _User = clsUsers.FindByUserID(UserID);
            
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            _UserID = UserID;
            _FillUserInfo();
        }

        public usctrlUserDetails()
        {
            InitializeComponent();
        }

        private void _ResetPersonInfo()
        {
            usctrlPersonDetails1.ResetPersonInfo();
            lblIsActiveValue.Text = "[???]";
            lblUserIDValue.Text = "[???]";
            lblUserNameValue.Text = "[???]";
        }


        private void _FillUserInfo()
        {
            usctrlPersonDetails1.LoadPersonInfo(_User.PersonID);

            lblUserNameValue.Text = _User.UserName;
            lblUserIDValue.Text = _User.UserID.ToString();

            if (_User.IsActive)
                lblIsActiveValue.Text = "Yes";
            else
                lblIsActiveValue.Text = "No";
        }

    }
}
