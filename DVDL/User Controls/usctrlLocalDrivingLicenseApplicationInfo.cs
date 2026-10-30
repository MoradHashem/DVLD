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
    public partial class usctrlLocalDrivingLicenseApplicationInfo : UserControl
    {
        private int _LocalDrivingLicenseApplicationID;
        private clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplications;

        public usctrlLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void ResetLocalDrivingLicenseApplicationInfo()
        {
            lblDLAID.Text = "[???]";
            lblAppliedForLicenseValue.Text = "[???]";
            lblPassedTests.Text = "[???]";
            lblApplicantValue.Text = "[???]";
            lblStatusValue.Text = "[???]";
            lblFeesValue.Text = "[???]";
            lblTypeValue.Text = "[???]";
            lblApplicantValue.Text = "[???]";
            lblDateValue.Text = "[???]";
            lblStatusDateValue.Text = "[???]";
            lblCreatedByValue.Text = "[???]";

        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            lnkViewPersonInfo.Enabled = true;


            lblDLAID.Text = _LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicenseValue.Text = _LocalDrivingLicenseApplications.LicenseClassInfo.LicenseName;
            lblPassedTests.Text = "0/3";
            lblApplicantValue.Text = _LocalDrivingLicenseApplications.ApplicationID.ToString();
            lblStatusValue.Text = _LocalDrivingLicenseApplications.StatusText;
            lblFeesValue.Text = _LocalDrivingLicenseApplications.PaidFees.ToString();
            lblTypeValue.Text = _LocalDrivingLicenseApplications.ApplicationTypeInfo.ApplicationTypeTitle;
            lblApplicantValue.Text = _LocalDrivingLicenseApplications.PersonFullName;
            lblDateValue.Text = _LocalDrivingLicenseApplications.ApplicationDate.ToShortDateString();
            lblStatusDateValue.Text = _LocalDrivingLicenseApplications.ApplicationStatus.ToString();
            lblCreatedByValue.Text = _LocalDrivingLicenseApplications.CreatedByUserInfo.UserName;
        }

        public void LoadLocalDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplications == null)
            {
                ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show("No Local Driving License Application with LocalDrivingLicenseApplicationID = " +
                    LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        private void lnkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmPersonDetails(_LocalDrivingLicenseApplications.ApplicantPersonID);

            frm.ShowDialog();

            _FillLocalDrivingLicenseApplicationInfo();
        }
    }
}
