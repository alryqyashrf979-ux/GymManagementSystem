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

        public event EventHandler<clsSubscription> AddedSubscription;


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
            tcSubscriptionInfo.SelectedTab = tcSubscriptionInfo.TabPages["tpSubscriptionInfo"];

            ctrlMemberDetailsWithFiltering1.EnableFiltering = false;
            ctrlSubscriptionPlanDetailsWithFiltering1.EnableFiltering = false;

            ctrlSubscriptionDetails1.EnableStartDate = true;
        }

        private void frmAddSubscription_Load(object sender, EventArgs e)
        {

            _Subscription = new clsSubscription();
            this.Text = "Add Subscription";
            lblTitle2.Text = "Add Subscription";
            ctrlSubscriptionDetails1.EnableStartDate = true;
            tpSubscriptionInfo.Enabled = false ;

            ctrlSubscriptionDetails1.MaxStartDateDelayDays = 14;



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
            {
                tcSubscriptionInfo.SelectedTab = tcSubscriptionInfo.TabPages["tpSubscriptionInfo"];
                tpSubscriptionInfo.Enabled = true;

            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID!=-1)
            if (!clsPayments.IsPaymentStatusCompeleted(ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID))
            {
                MessageBox.Show($"Warnining!\n\nThis member has an outstanding balance from a previous subscription \nOutstanding Balance:{clsPayments.FindBySubscriptionID(ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID).TotalRemaining:N2} ","Outstanding Balance Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            bool IsSaved = false;

            if (_Mode == enMode.AddMode)
            {
                IsSaved = _Subscription.AddSubscription(ctrlSubscriptionDetails1.StartDate, ctrlMemberDetailsWithFiltering1.MemberID,
                    ctrlSubscriptionPlanDetailsWithFiltering1.SelectedPlan.PlanID, clsGlobal.CurrentUserInfo.UserID);
            }
            else
                IsSaved = _Subscription.UpdateSubscription(ctrlSubscriptionDetails1.StartDate, clsGlobal.CurrentUserInfo.UserID);

            if (IsSaved)
            {
                _Mode = enMode.UpdateMode;


                AddedSubscription?.Invoke(this, _Subscription);

                lblTitle2.Text = "Update SubscriPtion";
                this.Text = "Update Subscription";

                MessageBox.Show("Data saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = (_Subscription.Status == clsSubscription.enSubscriptionStatus.Scheduled);
                ctrlSubscriptionDetails1.EnableStartDate = btnSave.Enabled;


                if (!btnSave.Enabled)
                    MessageBox.Show("The start date cannot be changed because this subscription is already active.", "Subscription connot be Modified", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                ctrlSubscriptionPlanDetailsWithFiltering1.EnableFiltering = false;
                ctrlMemberDetailsWithFiltering1.EnableFiltering = false;

                ctrlSubscriptionDetails1.LoadSubscriptionDetails(_Subscription.SubscriptionID);

                this.Close();
                frmAddUpdatePayment frm = new frmAddUpdatePayment(_Subscription.MemberID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);






        }

        private void ctrlMemberDetailsWithFiltering1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {


            if (e.MemberInfo == null)
                return;


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

        public void LoadMemberDetails(int MemberID)
        {
            ctrlMemberDetailsWithFiltering1.LoadMemberInfoByMemberID(MemberID);
            ctrlMemberDetailsWithFiltering1.EnableFiltering = false;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tcSubscriptionInfo.SelectedTab = tcSubscriptionInfo.TabPages["tpMemberInfo"];
        }

     
    }
}
