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
    public partial class frmAddUpdateCancelSubscription : Form
    {
        public frmAddUpdateCancelSubscription()
        {
            InitializeComponent();
        }
        public frmAddUpdateCancelSubscription(int CanceledSubscriptionID)
        {
            InitializeComponent();
            _CanceledSubscriptionID = CanceledSubscriptionID;
            _Mode = enMode.Update;
        }

        enum enMode { Addnew = 1, Update = 2 };
        enMode _Mode = enMode.Addnew;
        short _ElapsedDays = 0;
        int _CanceledSubscriptionID = -1;
        clsSubscriptionCancellation _CanceldSubscription;

        void _DefaultValues()
        {


            if (_Mode == enMode.Addnew)
                _CanceldSubscription = new clsSubscriptionCancellation();


            lblCanceledByUser.Text = "[????]";
            lblCancellationDate.Text = DateTime.Today.Date.ToString();
            lblElapsedDays.Text = "[????]";
            lblSubscriptionCancellationID.Text = "[????]"; 
            lblSubscriptionID.Text = "[????]";
            lblTitle.Text = "Add Cancel Subscription";
            this.Text = lblTitle.Text;
            txtCancellationReason.Text = string.Empty;
            txtFees.Text = "0";


        }

        void _LoadDate()
        {



            lblTitle.Text = "Update Cancelled Subscription";
            this.Text = lblTitle.Text;

            _CanceldSubscription = clsSubscriptionCancellation.Find(_CanceledSubscriptionID);

            if (_CanceldSubscription == null)
            {

                MessageBox.Show($"Canceled Subscription with ID {_CanceledSubscriptionID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                pnlCancelSubscription.Enabled = false;
                return;
            }

            lblCanceledByUser.Text = _CanceldSubscription.CancelledByUserInfo.UserName;
            lblCancellationDate.Text= _CanceldSubscription.CancellationDate.ToString();
            lblElapsedDays.Text= _CanceldSubscription.ElapsedDays.ToString();
            lblSubscriptionCancellationID.Text= _CanceldSubscription.CancellationID.ToString();
            lblSubscriptionID.Text= _CanceldSubscription.SubscriptionID.ToString();
            txtCancellationReason.Text = _CanceldSubscription.CancellationReason;
            txtFees.Text = _CanceldSubscription.Refund.ToString();




        }


        private void frmAddUpdateCancelSubscription_Load(object sender, EventArgs e)
        {
            _DefaultValues();

            if (_Mode == enMode.Update)
                _LoadDate();
        }

        private void ctrlMemberBasicDetailsWithFilter1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {
            btnSave.Enabled = false;
            pnlCancelSubscription.Enabled = false;

            if (e.MemberInfo == null)
                return;


            if (e.MemberInfo.LastSubscriptionID == -1 || e.MemberInfo.LastSubscriptionInfo.Status != clsSubscription.enSubscriptionStatus.Active)
            {
                MessageBox.Show("No Active Subscription found for this member.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblSubscriptionID.Text = e.MemberInfo.LastSubscriptionID.ToString();
            btnSave.Enabled = true;
            pnlCancelSubscription.Enabled = true;

            _ElapsedDays =(short) (e.MemberInfo.LastSubscriptionInfo.ExpirationDate.Date - DateTime.Today.Date).Days;
            lblElapsedDays.Text = _ElapsedDays.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            _CanceldSubscription.CancelledByUserID = clsGlobal.CurrentUserInfo.UserID;
            _CanceldSubscription.CancellationReason = txtCancellationReason.Text;
            _CanceldSubscription.SubscriptionID = ctrlMemberBasicDetailsWithFilter1.MemberInfo.LastSubscriptionID;
            _CanceldSubscription.ElapsedDays = _ElapsedDays;
            _CanceldSubscription.Refund = Convert.ToDouble(txtFees);


            if (_CanceldSubscription.Save())
            {

                _Mode = enMode.Update;
                lblTitle.Text = "Update Cancelled Subscription";
                this.Text = lblTitle.Text;

                lblSubscriptionCancellationID.Text = _CanceldSubscription.CancellationID.ToString();


                MessageBox.Show("Data saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }
}
}
