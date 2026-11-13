using DataBusinessLayer;
using GymMangementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            Form frm = new frmManageClasses();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void btnMangePayment_Click(object sender, EventArgs e)
        {
            Form frm = new frmManagePayments();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void btnSubscriPtions_Click(object sender, EventArgs e)
        {
            cmsSubscriptions.Show(btnSubscriPtions, new Point(btnSubscriPtions.Width, 0));
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

        private void freezeSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFreezeSubscription frm =new frmFreezeSubscription();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void cancelSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelSubscription frm = new frmCancelSubscription();
            frm.ShowDialog();
            _SelectbtnDashBoard();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageClassRegisteration();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void changeSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeSubscription frm =new frmChangeSubscription();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageEmployees();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

        private void btnManageTrainers_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageCoaches();
            frm.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageEmployeesAttendance();
            frm.ShowDialog();
            _SelectbtnDashBoard();

        }

      

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(clsGlobal.CurrentUserInfo.UserID);
            frm.ShowDialog();
            _SelectbtnDashBoard();


        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmChangePassword frm =new frmChangePassword(clsGlobal.CurrentUserInfo.UserID);
            frm.ShowDialog();
            _SelectbtnDashBoard();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUserInfo = null;
            _frmLogin.Show();
            this.Close();
        }

        private void _ResetDefaultValues()
        {
            lblCurrentUseName.Text = clsGlobal.CurrentUserInfo.UserName;
            lblUserName.Text = clsGlobal.CurrentUserInfo.UserName;

            lblCountActiveMembers.Text = clsMembers.SelectCountOfActiveMembers().ToString();
            lblActiveTrainers.Text = clsCoaches.SelectCountOfActiveCoaches().ToString();
            lblActiveClasses.Text = clsClasses.SelectCountOfActiveClasses().ToString();
            lblExpiringSubscription.Text = clsSubscription.SelectCountExpirationSubscriptionInLastTenDays().ToString();
            dgvShowMembersInLast15DaysList.DataSource = clsMembers.GetMembersInLast15Days();
            pbCurrentUser.ImageLocation = clsGlobal.CurrentUserInfo.PersonInfo.ImagePath;
            dgvClassList.DataSource = clsClasses.GetActiveClasses();
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (!File.Exists(clsGlobal.CurrentUserInfo.PersonInfo.ImagePath))
            {
                if (clsGlobal.CurrentUserInfo.PersonInfo.Gender == 0)
                    pbCurrentUser.Image = Resources.Male;
                else
                    pbCurrentUser.Image = Resources.Female;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string FormattedDate = date.ToString("dddd,d MMMM yyyy", CultureInfo.InvariantCulture);
            lblDate.Text = FormattedDate;
            lblTime.Text = date.ToString("hh:mm tt");
        }

        private void lnkViewAllMembers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmManageMember();
            frm.ShowDialog();
        }

        private void lnkViewAllClasses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmManageClasses();
            frm.ShowDialog();
        }

        private void btnAddSubscription_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddSubscription();
            frm.ShowDialog();
        }

        private void btnChangeSubscription_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangeSubscription();
            frm.ShowDialog();
        }

        private void btnCancelSubscription_Click(object sender, EventArgs e)
        {
            Form frm = new frmCancelSubscription();
            frm.ShowDialog();
        }

        private void btnFreezeSubscription_Click(object sender, EventArgs e)
        {
            Form frm = new frmFreezeSubscription();
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            cmsSetting.Show(btnSettings, new Point(btnSettings.Width, 0));
        }
    }
}
