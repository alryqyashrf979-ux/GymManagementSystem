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
        enum enMode { ExistSubscription, NewSubscription }
        private enMode _Mode = enMode.ExistSubscription;
        private clsPayments _PaymentInfo;
        private clsMembers _MemberInfo;
        private int _MemberID=-1;
        private int _SubscriptionID=-1;
        private decimal _Value = 0;
        public frmAddUpdatePayment()
        {
            InitializeComponent();
            _Mode = enMode.ExistSubscription;
        }
        public frmAddUpdatePayment(int MemberID)
        {
            InitializeComponent();
            _Mode = enMode.NewSubscription;
            _MemberID = MemberID;
        }
    
        private void _ResetDefaultValues()
        {
            
                lblTitle2.Text = "Add Payment";
                _PaymentInfo = new clsPayments();
      
            txtPaymentAmount.Text = "0";
            cmPaymentMethod.SelectedIndex = 0;
            tpPaymentInfo.Enabled = false;


        }
        private void _LoadData()
        {
            _MemberInfo = clsMembers.FindMemberUsingMemberID(_MemberID);
            if (_MemberInfo == null)
            {
                MessageBox.Show($"Member with ID {_MemberID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlMemberDetailsWithFiltering1.LoadMemberInfoByMemberID(_MemberInfo.MemberID);
            ctrlMemberDetailsWithFiltering1.EnableFiltering = false;
            tcPayment.SelectedTab = tcPayment.TabPages["tpPaymentInfo"];
            btnSave.Enabled = true;
            tpPaymentInfo.Enabled = true;
            lnkShowSubscriptionDetails.Enabled = true;
            _SubscriptionID = _MemberInfo.LastSubscriptionID;

        }
    

       

        private void frmAddUpdatePayment_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.NewSubscription)
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
                    btnSave.Enabled = (ctrlPaymentDetails1.Payment.Status != 2);
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
            // _SubscriptionID = ctrlPaymentDetails1.Payment == null ? _SubscriptionID : ctrlPaymentDetails1.Payment.SubscriptionID;
            _SubscriptionID = ctrlPaymentDetails1.Payment?.SubscriptionID ?? _SubscriptionID;
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
            decimal TotalRemaining = Convert.ToDecimal(ctrlPaymentDetails1.Payment?.TotalRemaining ?? ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionInfo.PlanInfo.PlanPrice);
            if (_Value > TotalRemaining)
            {
                MessageBox.Show(txtPaymentAmount, $"Payment amount cannot exceed the remaining balance.\n Remaining Balance:{TotalRemaining:N1}\nEntered Amount:{txtPaymentAmount.Text:N2}", "Invalid Payment Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _PaymentInfo.PaymentAmount=Convert.ToDouble( txtPaymentAmount.Text);
            _PaymentInfo.PaymentMethod = (cmPaymentMethod.Text == "Cash") ? (int)clsPayments.enPaymentMethod.Cash : (int)clsPayments.enPaymentMethod.Card;
            _PaymentInfo.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;
            _PaymentInfo.ActualAmount = ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionInfo.PlanInfo.PlanPrice;
            double OldPaymentAmount = ctrlPaymentDetails1.Payment == null ? 0 :ctrlPaymentDetails1.Payment.ActualAmount- ctrlPaymentDetails1.Payment.TotalRemaining;
         
            if (_Mode==enMode.ExistSubscription)
            {
                _PaymentInfo.TotalRemaining = Math.Max(0, ctrlPaymentDetails1.Payment.ActualAmount - (_PaymentInfo.PaymentAmount + OldPaymentAmount));// this mean choose the max one.
                _PaymentInfo.Status = (_PaymentInfo.TotalRemaining == 0) ? (byte)clsPayments.enStatus.Completed : (byte)clsPayments.enStatus.Pending;
            }
            else
            {
                _PaymentInfo.TotalRemaining = Math.Max(0, _PaymentInfo.ActualAmount - (_PaymentInfo.PaymentAmount + OldPaymentAmount));// this mean choose the max one.
                _PaymentInfo.Status = (_PaymentInfo.TotalRemaining == 0) ? (byte)clsPayments.enStatus.Completed : (byte)clsPayments.enStatus.Pending;
            }

            _PaymentInfo.SubscriptionID = ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID;


            if (_PaymentInfo.Save())
            {
                lblTitle2.Text = "Update Payment";
                ctrlPaymentDetails1.LoadPaymentInfo(_PaymentInfo.PaymentID);
                btnSave.Enabled = false;
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

        private void txtPaymentAmount_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            if (!decimal.TryParse(txtPaymentAmount.Text, out _Value))
            {
                errorProvider1.SetError(txtPaymentAmount, "Payment amount must be valid.");
                    return;
            }

            if (_Value <= 0)
            {
                errorProvider1.SetError(txtPaymentAmount, "Payment amount must be greater than zero.");
                return;
            }


            errorProvider1.SetError(txtPaymentAmount, "");
            e.Cancel = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcPayment.SelectedTab = tcPayment.TabPages["tpMemberInfo"];

        }
    }
}
