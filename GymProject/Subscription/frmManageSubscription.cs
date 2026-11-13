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
    public partial class frmManageSubscription : Form
    {
        public frmManageSubscription()
        {
            InitializeComponent();
        }



        DataTable SubscriptionsList;

        private void frmManageSubscription_Load(object sender, EventArgs e)
        {
            _RefreshDataTable();
        }


        void _RefreshDataTable()
        {

            SubscriptionsList = clsSubscription.GetAllSubscriptions();
            dgvSubscriptionsList.DataSource = SubscriptionsList;

            lblRecord.Text=dgvSubscriptionsList.Rows.Count.ToString();
        }

        private void cmSelectTypeOfFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Visible = (cmSelectTypeOfFiltering.Text != "None" && cmSelectTypeOfFiltering.Text != "Status" && cmSelectTypeOfFiltering.Text != "Plan Name");
            cmPlanNames.Visible = (cmSelectTypeOfFiltering.Text == "Plan Name");
            cmStatus.Visible = (cmSelectTypeOfFiltering.Text == "Status");

            txtFiltering.InputType = (cmSelectTypeOfFiltering.Text == "Subscription ID") ? MyTextBox.TextType.Numeric : MyTextBox.TextType.Text;

            SubscriptionsList.DefaultView.RowFilter = "";
            lblRecord.Text = dgvSubscriptionsList.Rows.Count.ToString();


            if (txtFiltering.Visible)
                txtFiltering.Text = "";

            if (cmPlanNames.Visible)
            {
                cmPlanNames.DisplayMember = "Name";
                cmPlanNames.DataSource = clsSubscriptionPlans.GetAllAvailabilityPlanNames();
                cmPlanNames.SelectedIndex = -1;
            }


        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {



            if(txtFiltering.Text == "")
            {
                SubscriptionsList.DefaultView.RowFilter = "";
                lblRecord.Text = dgvSubscriptionsList.Rows.Count.ToString();
                return;
            }

            if (txtFiltering.InputType == MyTextBox.TextType.Numeric)
                SubscriptionsList.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] = '{txtFiltering.Text}'";
            else
                SubscriptionsList.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] like '{txtFiltering.Text}%'";



            lblRecord.Text = dgvSubscriptionsList.Rows.Count.ToString();

        }

        private void cmStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if(cmStatus.Text=="All")
            {
                SubscriptionsList.DefaultView.RowFilter = "";
                lblRecord.Text = dgvSubscriptionsList.Rows.Count.ToString();
                return; 
            }


                SubscriptionsList.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] like '{cmStatus.Text}'";



        }

        private void cmPlanNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cmPlanNames.SelectedIndex==-1)
            {
                SubscriptionsList.DefaultView.RowFilter = "";
                lblRecord.Text = dgvSubscriptionsList.Rows.Count.ToString();

                return;
            }

           
                SubscriptionsList.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] like '{cmPlanNames.Text}'";
                lblRecord.Text = dgvSubscriptionsList.Rows.Count.ToString();
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAddSubscription frm = new frmAddSubscription();
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowSubscriptionDetails frm = new frmShowSubscriptionDetails((int)dgvSubscriptionsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void addSubscripionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSubscription frm = new frmAddSubscription();
            frm.ShowDialog();
            _RefreshDataTable();

        }

        private void cancelSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsSubscription subscription = clsSubscription.FindBySubscriptionID((int)dgvSubscriptionsList.CurrentRow.Cells[0].Value);

            if(subscription==null)
            {
                MessageBox.Show($"Subscription with ID {dgvSubscriptionsList.CurrentRow.Cells[0].Value} not found ", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           frmCancelSubscription frm = new frmCancelSubscription(subscription.MemberID);
            frm.ShowDialog();
            _RefreshDataTable();

        }

        private void changeSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsSubscription subscription = clsSubscription.FindBySubscriptionID((int)dgvSubscriptionsList.CurrentRow.Cells[0].Value);

            if (subscription == null)
            {
                MessageBox.Show($"Subscription with ID {dgvSubscriptionsList.CurrentRow.Cells[0].Value} not found ", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            frmChangeSubscription frm = new frmChangeSubscription(subscription.MemberID);
            frm.ShowDialog();   
            _RefreshDataTable();
        }

        private void freezeSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {


            clsSubscription subscription = clsSubscription.FindBySubscriptionID((int)dgvSubscriptionsList.CurrentRow.Cells[0].Value);

            if (subscription == null)
            {
                MessageBox.Show($"Subscription with ID {dgvSubscriptionsList.CurrentRow.Cells[0].Value} not found ", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            frmFreezeSubscription frm = new frmFreezeSubscription(subscription.MemberID);
            frm.ShowDialog();
            _RefreshDataTable();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int Index = (int)dgvSubscriptionsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete Subscription [" + Index + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                if (clsSubscription.DeleteSubscription(Index))
                {
                    MessageBox.Show("Subscription deleted successfully.", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDataTable();
                }
                else
                    MessageBox.Show("Subscription was not Deleted because it has data link to it", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {


            clsSubscription subscription = clsSubscription.FindBySubscriptionID((int)dgvSubscriptionsList.CurrentRow.Cells[0].Value);

            if (subscription == null)
            {
                MessageBox.Show($"Subscription with ID {dgvSubscriptionsList.CurrentRow.Cells[0].Value} not found ", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            freezeSubscriptionToolStripMenuItem.Enabled = (subscription.Status == clsSubscription.enSubscriptionStatus.Active);
            changeSubscriptionToolStripMenuItem.Enabled= (subscription.Status == clsSubscription.enSubscriptionStatus.Active);
            cancelSubscriptionToolStripMenuItem.Enabled= (subscription.Status == clsSubscription.enSubscriptionStatus.Active);
            unFreezeToolStripMenuItem.Enabled= (subscription.Status == clsSubscription.enSubscriptionStatus.Frozen);
           startSubscriptionToolStripMenuItem.Enabled= (subscription.Status == clsSubscription.enSubscriptionStatus.Scheduled);


            expiredToolStripMenuItem.Enabled= (subscription.Status == clsSubscription.enSubscriptionStatus.Active&&DateTime.Today.Date==subscription.ExpirationDate.Date);





        }

        private void unFreezeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSubscription subscription = clsSubscription.FindBySubscriptionID((int)dgvSubscriptionsList.CurrentRow.Cells[0].Value);

            if (subscription == null)
            {
                MessageBox.Show($"Subscription with ID {dgvSubscriptionsList.CurrentRow.Cells[0].Value} not found ", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (subscription.UnFreeze(clsGlobal.CurrentUserInfo.UserID))
            {
                MessageBox.Show($"The Subscription has been successfully unfrozen and is now active", "Subscription UnFrozen successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataTable();

            }
            else
                MessageBox.Show($"The Subscription could not be Unfrozen. Please try again.", "Failed UnFrozen Subscription.", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void expiredToolStripMenuItem_Click(object sender, EventArgs e)
        {


            clsSubscription subscription = clsSubscription.FindBySubscriptionID((int)dgvSubscriptionsList.CurrentRow.Cells[0].Value);

            if (subscription == null)
            {
                MessageBox.Show($"Subscription with ID {dgvSubscriptionsList.CurrentRow.Cells[0].Value} not found ", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (subscription.ExpireSubscription())
            {
                MessageBox.Show($"The Subscription has been successfully expired.", "Subscription Expired successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataTable();

            }
            else
                MessageBox.Show($"Unable to Expire the Subscription. Please try again.", "Failed Expire Subscription.", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void startSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsSubscription subscription = clsSubscription.FindBySubscriptionID((int)dgvSubscriptionsList.CurrentRow.Cells[0].Value);

            if (subscription == null)
            {
                MessageBox.Show($"Subscription with ID {dgvSubscriptionsList.CurrentRow.Cells[0].Value} not found ", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (subscription.StartSubscription())
            {
                MessageBox.Show($"The Subscription is now active", "Subscription Start successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataTable();

            }
            else
                MessageBox.Show($"Unable to Start the Subscription. Please try again.", "Failed to Start Subscription.", MessageBoxButtons.OK, MessageBoxIcon.Error);







        }
    }
}
