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

        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            Form frm = new frmManagePeople();
            frm.ShowDialog();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void btnManageMember_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageMember();
            frm.ShowDialog();
        }

        private void btnManageClasses_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmClasses();
            frm.ShowDialog();
        }
    }
}
