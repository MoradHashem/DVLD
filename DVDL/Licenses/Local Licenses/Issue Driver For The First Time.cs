using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Licenses.Local_Licenses
{
    public partial class frmIssueDriverForTheFirstTime : Form
    {
        private int _LocalDrivingLicenseApplication = -1;

        public frmIssueDriverForTheFirstTime(int LocalDrivingLicenseApplication)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplication;
        }
    }
}
