using DataBusinessLayer;
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
    public partial class ctrlSubscriptionsHistory : UserControl
    {

        clsMembers _MemberInfo;
        public ctrlSubscriptionsHistory()
        {
            InitializeComponent();
        }


        void _LoadSubscriptionsHistroy()
        {


            dgvExpiredSubscriptions.DataSource = _MemberInfo.LastSubscriptionInfo.GetAllExpiredSubscriptions();
            lblExpiredRecord.Text = dgvExpiredSubscriptions.Rows.Count.ToString();

            dgvFrozenSubscriptions.DataSource = _MemberInfo.LastSubscriptionInfo.GetAllFrozenSubscriptions();
            lblFrozenRecord.Text = dgvFrozenSubscriptions.Rows.Count.ToString();


            dgvChangedSubscriptions.DataSource = _MemberInfo.LastSubscriptionInfo.GetAllChangedSubscriptions();
            lblChangedRecord.Text = dgvChangedSubscriptions.Rows.Count.ToString();

            dgvCancelledSubscriptions.DataSource = _MemberInfo.LastSubscriptionInfo.GetAllCancelledSubscriptions();
            lblCancelledRecord.Text = dgvCancelledSubscriptions.Rows.Count.ToString();

        }





        public void LoadMemberSubscriptionsHistory(int MemberID)
        {

            _MemberInfo = clsMembers.FindMemberUsingMemberID(MemberID);

            if (_MemberInfo == null)
            {
                MessageBox.Show($"Member with ID {MemberID} not found ", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadSubscriptionsHistroy();


        }

        private void showExpiringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowSubscriptionDetails frm = new frmShowSubscriptionDetails((int)dgvExpiredSubscriptions.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showFrozenSubscriptionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowSubscriptionDetails frm = new frmShowSubscriptionDetails((int)dgvFrozenSubscriptions.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showCancelledSubscriptionDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmShowSubscriptionDetails frm = new frmShowSubscriptionDetails((int)dgvCancelledSubscriptions.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showChangeSubscriptionDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmShowSubscriptionDetails frm = new frmShowSubscriptionDetails((int)dgvChangedSubscriptions.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
