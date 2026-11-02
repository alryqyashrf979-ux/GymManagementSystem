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

        private int _SubscriptionID=-1;
        private int _MemberID=-1;

        private bool _IsContinueToPayment = false;
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

            if(_IsContinueToPayment)// in case come from frmAddUpdateSubscription .
            PrepareForContinuePayment(_SubscriptionID,_MemberID);
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
            btnSave.Enabled = false;
            tpPaymentInfo.Enabled = false;

            if (ctrlMemberDetailsWithFiltering1.MemberID!=-1)
          { 
                if (ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID!=-1)
                {
                    btnSave.Enabled = true;
                    tpPaymentInfo.Enabled = true;
                    tcPayment.SelectedTab = tcPayment.TabPages["tpPaymentInfo"];
                    ctrlPaymentDetails1.LoadPaymentInfo(clsPayments.SelectPaymentIDBySubscriptionID(ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID));
                    lnkShowSubscriptionDetails.Enabled = true;

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
            _SubscriptionID = ctrlPaymentDetails1.Payment == null ? _SubscriptionID : ctrlPaymentDetails1.Payment.SubscriptionID;

            Form frm = new frmShowSubscriptionDetails(_SubscriptionID);
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
            double OldPaymentAmount = ctrlPaymentDetails1.Payment == null ? 0 :ctrlPaymentDetails1.Payment.ActualAmount- ctrlPaymentDetails1.Payment.TotalRemaining;
            _PaymentInfo.TotalRemaining = Math.Max(0, ctrlPaymentDetails1.Payment.ActualAmount - (_PaymentInfo.PaymentAmount+ OldPaymentAmount));// this mean choose the max one.
            _PaymentInfo.SubscriptionID = ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID;
            _PaymentInfo.ActualAmount = ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionInfo.PlanInfo.PlanPrice;
            _PaymentInfo.Status = (_PaymentInfo.TotalRemaining == 0) ? (byte)clsPayments.enStatus.Completed : (byte)clsPayments.enStatus.Pending;


            if (_PaymentInfo.Save())
            {
                lblTitle2.Text = "Update Payment";
                ctrlPaymentDetails1.LoadPaymentInfo(_PaymentInfo.PaymentID);
                MessageBox.Show("Payment details saved successfully.", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error :Faild to save data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddSubscription frm = new frmAddSubscription();
            frm.LoadMemberDetails(ctrlMemberDetailsWithFiltering1.MemberID);
            frm.ShowDialog();
        }

        public void PrepareForContinuePayment(int SubscriptionID,int MemberID)
        {                                                                        //you will say why call it from reset function because in normal way we make btnsave and tabpage disable but in this case we prepare form.
            lnkShowSubscriptionDetails.Enabled = true;
            this._SubscriptionID = SubscriptionID;
            this._MemberID = MemberID;

            btnSave.Enabled = true;
            tpPaymentInfo.Enabled = true;
            tcPayment.SelectedTab = tcPayment.TabPages["tpPaymentInfo"];
            ctrlMemberDetailsWithFiltering1.LoadMemberInfoByMemberID(MemberID);
            _IsContinueToPayment = true;
        }
    }
}
