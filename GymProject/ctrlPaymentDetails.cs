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
            lblStatus.Text = "???";
        }

        
        void _LoadData()
        {
            lblStatus.Text = Payment.StatusString;
            lblActualAmount.Text = Payment.ActualAmount.ToString();
            lblCreatedBy.Text = Payment.UserInfo.UserName;
            lblMemberName.Text = Payment.MemberInfo.PersonInfo.FullName;
            lblPaymentAmount.Text = Payment.PaymentAmount.ToString();
            lblPaymentD.Text = Payment.PaymentID.ToString();
            lblPaymentDate.Text = Payment.PaymentDate.ToString();
            lblPlanName.Text = Payment.SubscriptionInfo.PlanInfo.PlanName;
            lblTotalRemaining.Text = Payment.TotalRemaining.ToString();
            lblSubscriptionID.Text = Payment.SubscriptionID.ToString();
        }

        public void LoadPaymentByPaymentID(int PaymentID)
        {
            Payment = clsPayments.FindByPaymentID(PaymentID);
            if (Payment == null)
            {
                _ResetDefaultValues();
                return;
            }

            _LoadData();//Edit By aim
        }
        // Added by aim \
        public void LoadPaymentBySubscriptionID(int SubscriptionID)
        {
            Payment = clsPayments.FindBySubscriptionID(SubscriptionID);

            if (Payment == null)
            {
                _ResetDefaultValues();
                return;
            }

            _LoadData();//Edit By aim
        }
    }
}
