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
    public partial class frmFreezeSubscription : Form
    {

       
       

        public frmFreezeSubscription()
        {
            InitializeComponent();
        }

        int _selectedMember = -1;
        public frmFreezeSubscription(int selectedMember)
        {
            InitializeComponent();
            _selectedMember = selectedMember;
        }
   
        void SelectedMember()
        {
            ctrlMemberBasicDetailsWithFilter1.LoadMemberInfoByMemberID(_selectedMember);
            ctrlMemberBasicDetailsWithFilter1.EnableFiltering = false;
        }



        private void ctrlMemberBasicDetailsWithFilter1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {
            btnSave.Enabled = false;
            pnlFrozenSubscription.Enabled = false;

            if (e.MemberInfo == null)
                return;

            if (e.MemberInfo.LastSubscriptionID == -1)
            {
                MessageBox.Show("this Member does not has an Existing Subscription, choose another one.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.MemberInfo.LastSubscriptionInfo.Status != clsSubscription.enSubscriptionStatus.Active)
            {
                MessageBox.Show("No Active Subscription found for this member.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblSubscriptionID.Text=e.MemberInfo.LastSubscriptionID.ToString();
            btnSave.Enabled = true;
            pnlFrozenSubscription.Enabled = true;

        }


        void _DefaultValues()
        {


            lblFreezingDuration.Text = "[????]";
            lblFrozenByUser.Text = "[????]";
            lblFrozenSubscriptionID.Text = "[????]";
            lblSubscriptionID.Text = "[????]";
            txtFees.Text = "0";
            lblTitle.Text = "Add Frozen Subscription";
            this.Text=lblTitle.Text;

            dtEndDate.MaxDate = DateTime.Today.AddYears(2);
            dtStartDate.MaxDate = DateTime.Today.AddMonths(5);
         
            dtStartDate.MinDate = DateTime.Today;
            dtEndDate.MinDate = DateTime.Today;




            dtStartDate.Value = DateTime.Today.Date;
            dtEndDate.Value = DateTime.Today;
        }

     
        private void frmAddUpdateFrozenSubscription_Load(object sender, EventArgs e)
        {
            _DefaultValues();
            if (_selectedMember != -1)
                SelectedMember();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            if (!this.ValidateChildren())
                return;

            if (MessageBox.Show("Are You Sure you want to Freeze this Subscription ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {

                return;
            }

            if (dtStartDate.Value.Date > dtEndDate.Value.Date)
            {
                MessageBox.Show("End Date can not be older than Start Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double Fees;

            if (txtFees.Text == "")
                Fees = 0;
            else
                Fees = Convert.ToDouble(txtFees.Text);


                int FrozenID = ctrlMemberBasicDetailsWithFilter1.MemberInfo.LastSubscriptionInfo.Freeze(dtStartDate.Value, dtEndDate.Value,
                    Fees, clsGlobal.CurrentUserInfo.UserID, txtFreezeReason.Text);


            if (FrozenID!=-1)
            {

                btnSave.Enabled = false;
                ctrlMemberBasicDetailsWithFilter1.EnableFiltering = false;
                lblFreezingDuration.Text = (dtEndDate.Value.Date - dtStartDate.Value.Date).Days.ToString();
                lblFrozenByUser.Text = clsGlobal.CurrentUserInfo.UserName;
                lblFrozenSubscriptionID.Text = FrozenID.ToString() ;


                MessageBox.Show("Data saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsNumber(txtFees.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number!");
                return;

            }
            else
            {
                errorProvider1.SetError(txtFees, "");
            }
            
        }

    }
}
