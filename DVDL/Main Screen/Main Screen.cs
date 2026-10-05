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
    public partial class MainScreen : Form
    {
        private clsUsers _User;


        public MainScreen()
        {
            InitializeComponent();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManagePeople();

            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();

            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _User = clsLoginInformation.GetUser();

            frmUserInformation frm = new frmUserInformation(_User.UserID, _User.PersonID);

            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _User = clsLoginInformation.GetUser();

            frmChangePassword frm = new frmChangePassword(_User.UserID, _User.PersonID);

            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLoginScreen frm = new frmLoginScreen();
            frm.ShowDialog();

            this.Close();
        }
    }
}