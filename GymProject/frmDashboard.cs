using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class frmDashboard : Form
    {
        private frmLogin _frmLogin;
        public frmDashboard(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }
        public frmDashboard()
        {
            InitializeComponent();
        }

        void _SelectbtnDashBoard()
        {
            btnDashboard.Checked = true;
        }

        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            Form frm = new frmManagePeople();
            frm.ShowDialog();
            _SelectbtnDashBoard();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void btnManageMember_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageMember();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void btnManageClasses_Click(object sender, EventArgs e)
        {
            Form frm = new frmClasses();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMangePayment_Click(object sender, EventArgs e)
        {
            Form frm = new frmManagePayments();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void btnSubscriPtions_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnSubscriPtions, new Point(btnSubscriPtions.Width, 0));
        }

        private void manageSubscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageSubscription frm =new frmManageSubscription();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void addSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSubscription frm =new frmAddSubscription();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }
    }
}
