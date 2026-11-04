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
            frmShowMemberDetails frm = new frmShowMemberDetails(_SubscriptionInfo.MemberID);
            frm.ShowDialog();
        }


        int _MaxStartDateDelayDays = 14;

        public DateTime StartDate
        {
            set => dtStartDate.Value = value;
            get=> dtStartDate.Value;
        }
    

        public clsSubscription SubscriptionInfo
        {
            get => _SubscriptionInfo;
        }

        private bool _EnableStartDate = false;
        public bool EnableStartDate 
        {
            set
            {
                dtStartDate.Enabled = value;
                _EnableStartDate = value;
            }

             get => dtStartDate.Enabled; 
        } 


        public int MemberID
        {
            set
            {
                lblMemberID.Text = value.ToString();
            }
        }

        public int MaxStartDateDelayDays
        {
            set
            {
                _MaxStartDateDelayDays = value;

                dtStartDate.MaxDate = DateTime.Today.AddDays(_MaxStartDateDelayDays);
                dtStartDate.MinDate = DateTime.Today;
                dtStartDate.Value = DateTime.Today;
            }
            get => _MaxStartDateDelayDays;
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
            lnkShowPlanDetails.Enabled = false;
            dtStartDate.Enabled = _EnableStartDate;

            MaxStartDateDelayDays= _MaxStartDateDelayDays;


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
            lnkShowPlanDetails.Enabled=( _SubscriptionInfo.PlanID != -1);
            dtStartDate.MaxDate = _SubscriptionInfo.RegistrationDate.AddDays(_MaxStartDateDelayDays);

            dtStartDate.MinDate = (DateTime.Today.Date < SubscriptionInfo.StartDate.Date)?DateTime.Now: _SubscriptionInfo.StartDate;

            dtStartDate.Value = _SubscriptionInfo.StartDate;

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

        private void lnkShowUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(_SubscriptionInfo.createdByUserID);
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowPlanDetails(_SubscriptionInfo.PlanID);
            frm.ShowDialog();
        }
    }
}
