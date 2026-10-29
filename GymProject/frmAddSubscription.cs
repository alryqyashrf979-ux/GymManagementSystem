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
    public partial class frmAddSubscription : Form
    {
        public frmAddSubscription()
        {
            InitializeComponent();
        }
        public enum enMode { AddMode, UpdateMode }
        enMode _Mode = enMode.AddMode;

        clsSubscription _Subscription;
        private void frmAddSubscription_Load(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateMode)
            {
                btnSave.Enabled = true;
                tpSubscriptionInfo.Enabled = true;
                tcSubscriptionInfo.SelectedTab = tcSubscriptionInfo.TabPages["tpSubscriptionInfo"];
                return;
            }

            if (ctrlMemberDetailsWithFiltering1.MemberID != -1)
            {
                if (clsSubscription.HasExistingSubscription(ctrlMemberDetailsWithFiltering1.MemberID))
                {
                    MessageBox.Show("Selected Member already has an Existing Subscription, choose another one.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlMemberDetailsWithFiltering1.Focus();
                }
                else
                {

                    btnSave.Enabled = true;
                    tpSubscriptionInfo.Enabled = true;
                    ctrlSubscriptionPlanDetailsWithFiltering1.LoadAvailabilityPlanNames();
                    ctrlSubscriptionDetails1.MemberID = ctrlMemberDetailsWithFiltering1.MemberID;
                    tcSubscriptionInfo.SelectedTab = tcSubscriptionInfo.TabPages["tpSubscriptionInfo"];

                }
            }
            else
            {
                MessageBox.Show("Please Select a Member", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlMemberDetailsWithFiltering1.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            _Subscription.StartDate = ctrlSubscriptionDetails1.StartDate;
            _Subscription.PlanID = ctrlSubscriptionPlanDetailsWithFiltering1.SelectedPlan.PlanID;
            _Subscription.MemberID = ctrlMemberDetailsWithFiltering1.MemberID;
            _Subscription.Price = ctrlSubscriptionPlanDetailsWithFiltering1.SelectedPlan.PlanPrice;
            _Subscription.createdByUserID=clsGlobal.CurrentUserInfo.UserID;


            if (_Subscription.Save())
            {
                _Mode = enMode.UpdateMode;

                ctrlSubscriptionDetails1.LoadSubscriptionDetails(_Subscription.SubscriptionID);
                MessageBox.Show("Data saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);






        }
    }
}
