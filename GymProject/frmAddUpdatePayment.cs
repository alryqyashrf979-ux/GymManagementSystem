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
using static DataBusinessLayer.clsPayments;

namespace GymMangementSystem
{
    public partial class frmAddUpdatePayment : Form
    {
        enum enMode { AddMode, UpdateMode }
        private enMode _Mode = enMode.AddMode;
        private int _PaymentID = -1;
        private clsPayments _PaymentInfo;
        public frmAddUpdatePayment()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }
        public frmAddUpdatePayment(int PaymentID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateMode;
            _PaymentID = PaymentID;
        }
    
        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddMode)
            {
                lblTitle2.Text = "Add Payment";
                _PaymentInfo = new clsPayments();
            }
            else
                lblTitle2.Text = "Update Payment";

            nudPaymentAmount.Value = 0;
            cmPaymentMethod.SelectedIndex = 0;
            tpPaymentInfo.Enabled = false;
        }
        private void _LoadData()
        {
            _PaymentInfo = clsPayments.Find(_PaymentID);
            if (_PaymentInfo == null)
            {
                MessageBox.Show($"Payment with ID {_PaymentID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlMemberDetailsWithFiltering1.LoadMemberInfoByMemberID(_PaymentInfo.MemberInfo.MemberID);
            ctrlMemberDetailsWithFiltering1.EnableFiltering = false;
            tcPayment.SelectedTab = tcPayment.TabPages["tpPaymentInfo"];
            btnSave.Enabled = true;
            ctrlPaymentDetails1.LoadPaymentInfo(_PaymentID);
        }
    

       

        private void frmAddUpdatePayment_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.UpdateMode)
                _LoadData();
        }

        private void ctrlMemberDetailsWithFiltering1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {
            if (e.MemberInfo == null)
            {
                btnSave.Enabled = false;
                tpPaymentInfo.Enabled = false;

            }
            else
                btnSave.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(ctrlMemberDetailsWithFiltering1.MemberID!=-1)
          { 
                if (clsSubscription.HasExistingSubscription(ctrlMemberDetailsWithFiltering1.MemberID))
                {
                    btnSave.Enabled = true;
                    tpPaymentInfo.Enabled = true;
                    tcPayment.SelectedTab = tcPayment.TabPages["tpPaymentInfo"];
                    ctrlPaymentDetails1.LoadPaymentInfo(clsPayments.SelectPaymentIDBySubscriptionID(ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID));


                }
                else
                    MessageBox.Show("Select a member that has supscription !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Select a member first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowSubscriptionDetails(ctrlPaymentDetails1.Payment.SubscriptionID);
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _PaymentInfo.PaymentAmount=Convert.ToDouble( nudPaymentAmount.Value);
            _PaymentInfo.PaymentMethod = (cmPaymentMethod.Text == "Cash") ? (int)clsPayments.enPaymentMethod.Cash : (int)clsPayments.enPaymentMethod.Card;
            _PaymentInfo.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;
            _PaymentInfo.SubscriptionID = ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID;
            _PaymentInfo.ActualAmount = ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionInfo.PlanInfo.PlanPrice;
            _PaymentInfo.TotalRemaining = Math.Max(0, _PaymentInfo.ActualAmount - _PaymentInfo.PaymentAmount);// this mean choose the max one.
            _PaymentInfo.PaymentDate = DateTime.Now;
            _PaymentInfo.Status = (_PaymentInfo.TotalRemaining == 0) ? (byte)clsPayments.enStatus.Completed : (byte)clsPayments.enStatus.Pending;


            if (_PaymentInfo.Save())
            {

            }
        }
    }
}
