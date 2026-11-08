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
using DVLDPresentationLayer.Licenses.Local_Licenses;

namespace DVLDPresentationLayer.User_Controls
{
    public partial class usctrlLocalDrivingLicenseApplicationInfo : UserControl
    {
        private int _LocalDrivingLicenseApplicationID = -1;

        private int _LicenseID;

        public int LocalDrivingLicenseApplicationID
        {
            get { return _LocalDrivingLicenseApplicationID; }
        }

        private clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplications;

        public usctrlLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            lblDLAID.Text = "[???]";
            lblAppliedForLicenseValue.Text = "[???]";
            lblPassedTests.Text = "[???]";
            usctrlApplicationBasicInfo1.ResetApplicationInfo();
        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            //_LicenseID = _LocalDrivingLicenseApplications.GetActiveLicenseID();

            lnkShowLicenseInfo.Enabled = false; //(_LicenseID != -1);

            lblDLAID.Text = _LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicenseValue.Text = clsLicenseClass.Find(_LocalDrivingLicenseApplications.LicenseClassID).LicenseName;
            lblPassedTests.Text = _LocalDrivingLicenseApplications.GetPassedTestCount().ToString() + "/3";
            usctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApplications.ApplicationID);
            
        }

        public void LoadApplicationInfoByLocalDrivingAppID(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplications == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        public void LoadApplicationInfoByApplicationID(int ApplicationID)
        {
            _LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByApplicationID(ApplicationID);
            if (_LocalDrivingLicenseApplications == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        private void lnkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form frm = new frmShowLicenseInfo(_LocalDrivingLicenseApplications.GetActiveLicenseID());

            //frm.ShowDialog();
        }
    }
}
