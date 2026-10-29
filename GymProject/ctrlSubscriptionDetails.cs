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
    public partial class ctrlSubscriptionDetails : UserControl
    {
        public ctrlSubscriptionDetails()
        {
            InitializeComponent();
        }


        clsSubscription _SubscriptionInfo;

        private void lnkShowMemberInof_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        int _MaxAllowDays = 14;

        public DateTime StartDate
        {
            set => dtStartDate.Value = value;
            get=> dtStartDate.Value;
        }
    

        public clsSubscription SubscriptionInfo
        {
            get => _SubscriptionInfo;
        }

       
        public bool EnableStartDate
        {
            set =>dtStartDate.Enabled = value;  
            get => dtStartDate.Enabled; 
        }


        public int MemberID
        {
            set
            {
                lblMemberID.Text = value.ToString();
            }
        }


        public void ResetSubscriptionData()
        {


            lblCreatedBy.Text = "[????]";
            lblMemberID.Text = "[????]";
            lblPlanID.Text = "[????]";
            lblStatus.Text= "[????]";
            lblSubscriptionID.Text = "[????]";
            lblPrice.Text = "[$$$]";
            lblExpirationDate.Text = "[yyyy/mm/dd]";
            lblRegistration.Text = "[yyyy/mm/dd]";
            lnkShowMemberInof.Enabled = false;
            lnkShowUserInfo.Enabled = false;

            dtStartDate.MaxDate = DateTime.Today.AddDays(14);
            dtStartDate.MinDate = DateTime.Now;
            dtStartDate.Value = DateTime.Now;


        }

        void _LoadData()
        {

            lblRegistration.Text=_SubscriptionInfo.RegistrationDate.ToString();
            lblCreatedBy.Text= _SubscriptionInfo.createdByUserID.ToString();
            lblMemberID.Text= _SubscriptionInfo.MemberID.ToString();
            lblPlanID.Text = _SubscriptionInfo.PlanID.ToString();
            lblPrice.Text= _SubscriptionInfo.Price.ToString();
            lblSubscriptionID.Text= _SubscriptionInfo.SubscriptionID.ToString();
            lblExpirationDate.Text= _SubscriptionInfo.ExpirationDate.ToString();
            lblStatus.Text = _SubscriptionInfo.StatusString;
            lnkShowMemberInof.Enabled = (_SubscriptionInfo.MemberID != -1);
            lnkShowUserInfo.Enabled= (_SubscriptionInfo.createdByUserID != -1);

            dtStartDate.Value = _SubscriptionInfo.StartDate;

            dtStartDate.MaxDate= _SubscriptionInfo.RegistrationDate.AddDays(_MaxAllowDays);
            dtStartDate.MinDate = DateTime.Today;

            dtStartDate.Enabled = EnableStartDate;
        }



        public void LoadSubscriptionDetails(int SubscriptionID)
        {
            _SubscriptionInfo=clsSubscription.FindBySubscriptionID(SubscriptionID);


            if (_SubscriptionInfo == null)
            {
                ResetSubscriptionData();
                MessageBox.Show("No Subscription with Subscription ID=" + SubscriptionID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();
        }

        private void ctrlSubscriptionDetails_Load(object sender, EventArgs e)
        {
        }
    }
}
