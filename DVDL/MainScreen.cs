using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }


        private void LoadManagePeopleScreenInPanel(Form frm)
        {
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }



        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ManagePeopleScreen();

            LoadManagePeopleScreenInPanel(frm);
        }
    }
}
