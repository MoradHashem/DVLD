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
    public partial class frmUserInformation : Form
    {
        private int _UserID;

        public frmUserInformation(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void User_Information_Load(object sender, EventArgs e)
        {
            usctrlUserDetails1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
