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
    public partial class ctrlPaymentDetails : UserControl
    {
        public clsPayments Payment { get; private set; }
        
        public ctrlPaymentDetails()
        {
            InitializeComponent();
        }
        private void _ResetDefaultValues()
        {
            lblActualAmount.Text = "???";
            lblCreatedBy.Text = "???";
            lblMemberName.Text = "???";
            lblPaymentAmount.Text = "???";
            lblPaymentD.Text = "???";
            lblPaymentDate.Text = "???";
            lblSubscriptionID.Text = "???";
            lblTotalRemaining.Text = "???";
            lblPlanName.Text = "???";

        }
        public void LoadPaymentInfo(int PaymentID)
        {
            Payment = clsPayments.Find(PaymentID);
            if (Payment == null)
            {
                _ResetDefaultValues();
                return;
            }

            lblActualAmount.Text = Payment.ActualAmount.ToString();
            lblCreatedBy.Text =Payment.UserInfo.UserName;
            lblMemberName.Text =Payment.MemberInfo.PersonInfo.FullName;
            lblPaymentAmount.Text = Payment.PaymentAmount.ToString();
            lblPaymentD.Text = Payment.PaymentID.ToString() ;
            lblPaymentDate.Text = Payment.PaymentDate.ToString();
            lblPlanName.Text =Payment.SubscriptionInfo.PlanInfo.PlanName ;
            lblTotalRemaining.Text =Payment.TotalRemaining.ToString();
            lblSubscriptionID.Text = Payment.SubscriptionID.ToString();
        }
    }
}
