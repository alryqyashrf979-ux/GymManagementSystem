using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class frmCancelSubscription : Form
    {
        public frmCancelSubscription()
        {
            InitializeComponent();
        }

        int _SelectedMember = -1;
        public frmCancelSubscription(int selectedMember)
        {
            InitializeComponent();
            _SelectedMember = selectedMember;
        }




        (double Fees, short ElapsedDays, double ElapsedDaysFees) _RefundInfo;


        void _DefaultValues()
        {


         
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

     
        void SelectedMember()
        {


            ctrlMemberBasicDetailsWithFilter1.LoadMemberInfoByMemberID(_SelectedMember);
            ctrlMemberBasicDetailsWithFilter1.EnableFiltering = false;

        }


        private void frmAddUpdateCancelSubscription_Load(object sender, EventArgs e)
        {
            _DefaultValues();

            if (_SelectedMember != -1)
                SelectedMember();




        }

        private void ctrlMemberBasicDetailsWithFilter1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {
            btnSave.Enabled = false;
            pnlCancelSubscription.Enabled = false;

            if (e.MemberInfo == null)
                return;

            if (e.MemberInfo.LastSubscriptionInfo.Status == clsSubscription.enSubscriptionStatus.Canceled)
            {
                MessageBox.Show("This subscription already Cancled.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.MemberInfo.LastSubscriptionID == -1 || e.MemberInfo.LastSubscriptionInfo.Status != clsSubscription.enSubscriptionStatus.Active)
            {
                MessageBox.Show("No Active Subscription found for this member.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          

            lblSubscriptionID.Text = e.MemberInfo.LastSubscriptionID.ToString();
            btnSave.Enabled = true;
            pnlCancelSubscription.Enabled = true;

            lblCanceledByUser.Text = clsGlobal.CurrentUserInfo.UserName;


            _RefundInfo= clsSubscriptionCancellation.RefundFees(e.MemberInfo);

            lblElapsedDays.Text = _RefundInfo.ElapsedDays.ToString();
            txtFees.Text = _RefundInfo.Fees.ToString();
            lblElapsedDaysFees.Text = _RefundInfo.ElapsedDaysFees.ToString();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (MessageBox.Show("Are You Sure you want to Cancel this Subscription ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {

                return;
            }


            int CancellationID = ctrlMemberBasicDetailsWithFilter1.MemberInfo.LastSubscriptionInfo.Cancel(clsGlobal.CurrentUserInfo.UserID,
                txtCancellationReason.Text, _RefundInfo.Fees);

            if (CancellationID!=-1)
            {

                lblSubscriptionCancellationID.Text = CancellationID.ToString();

                btnSave.Enabled = false;
                MessageBox.Show("Data saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }
}
}
