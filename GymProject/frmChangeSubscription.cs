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
    public partial class frmChangeSubscription : Form
    {
        public frmChangeSubscription()
        {
            InitializeComponent();
        }

        private void frmChangeSubscription_Load(object sender, EventArgs e)
        {

        }

        private void ctrlMemberDetailsWithFiltering1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void ctrlMemberBasicDetailsWithFilter1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {
            btnNext.Enabled = false;
            btnSave.Enabled = false;
            tbChange.Enabled = false;
            if (e.MemberInfo == null)
                return;


            if (e.MemberInfo.LastSubscriptionID == -1)
            {
                MessageBox.Show("this Member does not has an Existing Subscription, choose another one.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.MemberInfo.LastSubscriptionID == -1 || e.MemberInfo.LastSubscriptionInfo.Status != clsSubscription.enSubscriptionStatus.Active)
            {
                MessageBox.Show("No Active Subscription found for this member.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnNext.Enabled = true;
            btnSave.Enabled = true;
            tbChange.Enabled = true;


        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {

            tbChangeSubscription.SelectedTab = tbChangeSubscription.TabPages["tbChange"];


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure you want to Freeze this Subscription ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {

                return;
            }
            int NewSubscriptionID = -1;

            int ChangeID = ctrlMemberBasicDetailsWithFilter1.MemberInfo.LastSubscriptionInfo.Change(clsGlobal.CurrentUserInfo.UserID, ctrlSubscriptionPlanDetailsWithFiltering1.PlanID,ref NewSubscriptionID);


            if (ChangeID != -1)
            {

                btnSave.Enabled = false;
                ctrlSubscriptionPlanDetailsWithFiltering1.EnableFiltering = false;
                ctrlSubscriptionDetails1.LoadSubscriptionDetails(NewSubscriptionID);

                MessageBox.Show($"Data saved successfully with Subscription ID [{ChangeID}]", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);





        }
    }
}
