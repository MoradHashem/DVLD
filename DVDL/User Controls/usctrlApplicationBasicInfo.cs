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

namespace DVLDPresentationLayer.User_Controls
{
    public partial class usctrlApplicationBasicInfo : UserControl
    {
        private clsApplications _Application;

        private int _ApplicationID = -1;

        public int ApplicationID
        {
            get { return _ApplicationID; }
        }

        public usctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplications.FindBaseApplication(ApplicationID);
            if (_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillApplicationInfo();
        }

        private void _FillApplicationInfo()
        {
            _ApplicationID = _Application.ApplicationID;
            lblIDValue.Text = _Application.ApplicationID.ToString();
            lblStatusValue.Text = _Application.StatusText;
            lblTypeValue.Text = _Application.ApplicationTypeInfo.ApplicationTypeTitle;
            lblFeesValue.Text = _Application.PaidFees.ToString();
            lblApplicantValue.Text = _Application.ApplicantFullName;
            lblDateValue.Text = clsFormat.DateToShort(_Application.ApplicationDate);
            lblStatusDateValue.Text = clsFormat.DateToShort(_Application.LastStatusDate);
            lblCreatedByValue.Text = _Application.CreatedByUserInfo.UserName;
        }

        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            lblIDValue.Text = "[????]";
            lblStatusValue.Text = "[????]";
            lblTypeValue.Text = "[????]";
            lblFeesValue.Text = "[????]";
            lblApplicantValue.Text = "[????]";
            lblDateValue.Text = "[????]";
            lblStatusDateValue.Text = "[????]";
            lblCreatedByValue.Text = "[????]";

        }

        private void lnkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmPersonDetails(_Application.ApplicantPersonID);

            frm.ShowDialog();

            LoadApplicationInfo(_ApplicationID);
        }
    }
}
