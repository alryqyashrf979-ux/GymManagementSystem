using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataBusinessLayer.clsSubscription;

namespace GymMangementSystem
{
    public partial class frmAddSubscription : Form
    {
        public frmAddSubscription()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }


        int _SubscriptionID;

        public frmAddSubscription(int SubscriptionID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateMode;
            _SubscriptionID = SubscriptionID;

        }
        public enum enMode { AddMode, UpdateMode }
        enMode _Mode = enMode.AddMode;

        clsSubscription _Subscription;

        public event 



       


        void _LoadData()
        {



            _Subscription = clsSubscription.FindBySubscriptionID(_SubscriptionID);


            if (_Subscription == null)
            {

                MessageBox.Show($"Subscription with ID {_SubscriptionID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;

            }

            lblTitle2.Text = "Update SubscriPtion";
            this.Text = "Update Subscription";

            ctrlMemberDetailsWithFiltering1.LoadMemberInfoByMemberID(_Subscription.MemberID);
            ctrlSubscriptionDetails1.LoadSubscriptionDetails(_SubscriptionID);
            ctrlSubscriptionPlanDetailsWithFiltering1.LoadPlanDetailsByPlanName(_Subscription.PlanInfo.PlanName);

            btnSave.Enabled = (_Subscription.Status == clsSubscription.enSubscriptionStatus.Scheduled);

            ctrlMemberDetailsWithFiltering1.EnableFiltering = false;
            ctrlSubscriptionPlanDetailsWithFiltering1.EnableFiltering = false;

            ctrlSubscriptionDetails1.EnableStartDate = true;
        }

        private void frmAddSubscription_Load(object sender, EventArgs e)
        {

            _Subscription = new clsSubscription();
            this.Text = "Add Subscription";
            lblTitle2.Text = "Add Subscription";
            ctrlSubscriptionDetails1.ResetSubscriptionData();
            tpSubscriptionInfo.Enabled = false;
        



            if (_Mode == enMode.UpdateMode)
                _LoadData();
            else
                ctrlSubscriptionPlanDetailsWithFiltering1.LoadAvailabilityPlanNames();


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

            if (ctrlMemberDetailsWithFiltering1.MemberID == -1)
            {
                btnNext.Enabled = false;
                tpSubscriptionInfo.Enabled = false;
                btnSave.Enabled = false;

                MessageBox.Show("Please Select a member .", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                tcSubscriptionInfo.SelectedTab = tcSubscriptionInfo.TabPages["tpSubscriptionInfo"];



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            _Subscription.StartDate = ctrlSubscriptionDetails1.StartDate;
            _Subscription.ExpirationDate = _Subscription.StartDate.AddDays(ctrlSubscriptionPlanDetailsWithFiltering1.SelectedPlan.Duration);
            _Subscription.createdByUserID = clsGlobal.CurrentUserInfo.UserID;

            if (_Mode == enMode.AddMode)
            {
                _Subscription.PlanID = ctrlSubscriptionPlanDetailsWithFiltering1.SelectedPlan.PlanID;
                _Subscription.MemberID = ctrlMemberDetailsWithFiltering1.MemberID;
                _Subscription.Price = ctrlSubscriptionPlanDetailsWithFiltering1.SelectedPlan.PlanPrice;
            }

            if (_Subscription.Save())
            {
                _Mode = enMode.UpdateMode;

                lblTitle2.Text = "Update SubscriPtion";
                this.Text = "Update Subscription";

                MessageBox.Show("Data saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = (_Subscription.Status == clsSubscription.enSubscriptionStatus.Scheduled);
                ctrlSubscriptionDetails1.EnableStartDate =btnSave.Enabled;


                if (!btnSave.Enabled)
                    MessageBox.Show("The start date cannot be changed because this subscription is already active.", "Subscription connot be Modified", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    

                ctrlSubscriptionPlanDetailsWithFiltering1.EnableFiltering = false;
                ctrlMemberDetailsWithFiltering1.EnableFiltering = false;

                ctrlSubscriptionDetails1.LoadSubscriptionDetails(_Subscription.SubscriptionID);

                
            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);






        }

        private void ctrlMemberDetailsWithFiltering1_OnMemberSelected(object sender, ctrlMemberDetailsWithFiltering.MemberEventArgs e)
        {

            if (e.MemberInfo.MemberID != -1)
            {
                if (clsSubscription.HasExistingSubscription(ctrlMemberDetailsWithFiltering1.MemberID))
                {
                    MessageBox.Show("Selected Member already has an Existing Subscription, choose another one.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlMemberDetailsWithFiltering1.Focus();
                    btnNext.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnSave.Enabled = true;
                    tpSubscriptionInfo.Enabled = true;
                    ctrlSubscriptionDetails1.MemberID = ctrlMemberDetailsWithFiltering1.MemberID;

                }
            }
           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tcSubscriptionInfo.SelectedTab = tcSubscriptionInfo.TabPages["tpMemberInfo"];

        }
    }
}
