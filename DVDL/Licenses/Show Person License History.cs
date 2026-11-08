using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Licenses
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _ApplicationPersonID = -1;

        public frmShowPersonLicenseHistory(int ApplicationPersonID)
        {
            InitializeComponent();

            _ApplicationPersonID = ApplicationPersonID;
        }

    }
}
