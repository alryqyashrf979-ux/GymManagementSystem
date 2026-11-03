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
        public clsPayments PaymentInfo { get; private set; }
        
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
            lblStatus.Text = PaymentInfo.StatusString;
            lblActualAmount.Text = PaymentInfo.ActualAmount.ToString();
            lblCreatedBy.Text = PaymentInfo.UserInfo.UserName;
            lblMemberName.Text = PaymentInfo.MemberInfo.PersonInfo.FullName;
            lblPaymentAmount.Text = PaymentInfo.PaymentAmount.ToString();
            lblPaymentD.Text = PaymentInfo.PaymentID.ToString();
            lblPaymentDate.Text = PaymentInfo.PaymentDate.ToString();
            lblPlanName.Text = PaymentInfo.SubscriptionInfo.PlanInfo.PlanName;
            lblTotalRemaining.Text = PaymentInfo.TotalRemaining.ToString();
            lblSubscriptionID.Text = PaymentInfo.SubscriptionID.ToString();
        }

        public void LoadPaymentByPaymentID(int PaymentID)
        {
            PaymentInfo = clsPayments.FindByPaymentID(PaymentID);
            if (PaymentInfo == null)
            {
                _ResetDefaultValues();
                return;
            }

            _LoadData();//Edit By aim
        }
        // Added by aim \
        public void LoadPaymentBySubscriptionID(int SubscriptionID)
        {
            PaymentInfo = clsPayments.FindBySubscriptionID(SubscriptionID);

            if (PaymentInfo == null)
            {
                _ResetDefaultValues();
                return;
            }

            _LoadData();//Edit By aim
        }
    }
}
