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
        private int _MemberID=-1;
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
      
            txtPaymentAmount.Text = "0";
            cmPaymentMethod.SelectedIndex = 0;
            tpPaymentInfo.Enabled = false;
            ctrlMemberDetailsWithFiltering1.EnableBtnAddNewMember = false;

        }
        private void _LoadData()
        {
            //_MemberInfo = clsMembers.FindMemberUsingMemberID(_MemberID);
            //if (_MemberInfo == null)
            //{
            //    MessageBox.Show($"Member with ID {_MemberID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            ctrlMemberDetailsWithFiltering1.LoadMemberInfoByMemberID(_MemberID);
            ctrlMemberDetailsWithFiltering1.EnableFiltering = false;
            tcPayment.SelectedTab = tcPayment.TabPages["tpPaymentInfo"];
            btnSave.Enabled = true;
            tpPaymentInfo.Enabled = true;
            ctrlPaymentDetails1.SubscriptionID = ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID;
            ctrlPaymentDetails1.EnableLnkShowSubscriptionDetails = true;
        }
    

       

        private void frmAddUpdatePayment_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.NewSubscription)
                _LoadData();


        }

        private void ctrlMemberDetailsWithFiltering1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {
            btnSave.Enabled = false;
            btnNext.Enabled = false;
            tpPaymentInfo.Enabled = false;
            //aim

            if (e.MemberInfo == null) return;

            //if (e.MemberInfo == null)
            //{ 
            //    tpPaymentInfo.Enabled = false;

            //}

            if (ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID == -1)
            {
                MessageBox.Show("This member does not has an Existing Subscription", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           

            if (ctrlMemberDetailsWithFiltering1.MemberID!=-1)
            { 
               
                    btnSave.Enabled = true;
                    tpPaymentInfo.Enabled = true;
                    tcPayment.SelectedTab = tcPayment.TabPages["tpPaymentInfo"];

                ctrlPaymentDetails1.LoadPaymentBySubscriptionID(ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID);
                btnSave.Enabled = (ctrlPaymentDetails1.PaymentInfo?.Status !=clsPayments.enStatus.Completed);
                
                
            }
            else
                MessageBox.Show("Select a member first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double TotalRemaining = (ctrlPaymentDetails1.PaymentInfo?.TotalRemaining ?? ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionInfo.PlanInfo.PlanPrice);
            if (Convert.ToDouble(txtPaymentAmount.Text.Trim()) > TotalRemaining)
            {
                MessageBox.Show(txtPaymentAmount, $"Payment amount cannot exceed the remaining balance.\n Remaining Balance:{TotalRemaining:N1}\nEntered Amount:{txtPaymentAmount.Text:N2}", "Invalid Payment Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           clsPayments _PaymentInfo = new clsPayments();

          
           
            _PaymentInfo.PaymentAmount = Convert.ToDouble(txtPaymentAmount.Text);
            _PaymentInfo.PaymentMethod = (cmPaymentMethod.Text == "Cash") ? clsPayments.enPaymentMethod.Cash :clsPayments.enPaymentMethod.Card;
            _PaymentInfo.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;
            _PaymentInfo.ActualAmount = ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionInfo.PlanInfo.PlanPrice;
            _PaymentInfo.SubscriptionID = ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID;


            double PreviousPaymentAmount = ctrlPaymentDetails1.PaymentInfo == null ? 0 : ctrlPaymentDetails1.PaymentInfo.PaymentAmount;



            //_PaymentInfo.TotalRemaining = clsPayments.CalculteTotalRemaining(_PaymentInfo.ActualAmount, OldPaymentAmount, _PaymentInfo.PaymentAmount);

            //_PaymentInfo.Status = (_PaymentInfo.TotalRemaining == 0) ? clsPayments.enStatus.Completed : clsPayments.enStatus.Pending;




            if (_PaymentInfo.ExecutePayment(PreviousPaymentAmount))
            {
                ctrlPaymentDetails1.LoadPaymentByPaymentID(_PaymentInfo.PaymentID);
                txtPaymentAmount.Text = "";
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



            if (txtPaymentAmount.Text =="0")
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
