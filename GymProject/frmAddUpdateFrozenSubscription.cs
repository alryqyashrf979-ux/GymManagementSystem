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
    public partial class frmAddUpdateFrozenSubscription : Form
    {

        int _SubscriptionID = -1;
        int _FrozenSubscripionID= -1;
        clsFrozenSubscription _FrozenSubscriptionInf;

        enum enMode { Addnew = 1, Update = 2 };
        enMode _Mode = enMode.Addnew;


        public frmAddUpdateFrozenSubscription()
        {
            InitializeComponent();
        }
        public frmAddUpdateFrozenSubscription(int FrozenSubscriptionID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _FrozenSubscripionID=FrozenSubscriptionID;
        }






        private void ctrlMemberBasicDetailsWithFilter1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {


            if (e.MemberInfo == null)
                return;


            if (e.MemberInfo.LastSubscriptionID == -1 || e.MemberInfo.LastSubscriptionInfo.Status!=clsSubscription.enSubscriptionStatus.Active)
            {
                MessageBox.Show("No Active Subscription found for this member.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _SubscriptionID=e.MemberInfo.LastSubscriptionID;    
            lblSubscriptionID.Text=_SubscriptionID.ToString();

        }


        void _DefaultValues()
        {


            lblFreezingDuration.Text = "[????]";
            lblFrozenByUser.Text = "[????]";
            lblFrozenSubscriptionID.Text = "[????]";
            lblSubscriptionID.Text = "[????]";

            lblTitle.Text = "Add Frozen Subscription";
            this.Text=lblTitle.Text;

            if (_Mode == enMode.Addnew)
                _FrozenSubscriptionInf = new clsFrozenSubscription();


            dtStartDate.MinDate = DateTime.Now;
            dtEndDate.MinDate = DateTime.Now;



        }

        void _LoadData()
        {

            lblTitle.Text = "Update Frozen Subscription";
            this.Text = lblTitle.Text;

            _FrozenSubscriptionInf = clsFrozenSubscription.FindByFreezeID(_FrozenSubscripionID);

            if (_FrozenSubscriptionInf == null)
            {

                MessageBox.Show($"Frozen Subscription with ID {_FrozenSubscripionID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                pnlFrozenSubscription.Enabled= false;   
                return;
            }

            lblFreezingDuration.Text = _FrozenSubscriptionInf.FreezingDuration.ToString();
            lblFrozenByUser.Text = _FrozenSubscriptionInf.FrozenByUserInfo.UserName;
            lblFrozenSubscriptionID.Text = _FrozenSubscriptionInf.FreezeID.ToString();
            lblSubscriptionID.Text = _FrozenSubscriptionInf.SubscriptionID.ToString();
            rdYes.Checked = _FrozenSubscriptionInf.IsFeesPaid;
            txtFreezeReason.Text= _FrozenSubscriptionInf.FreezeReason.ToString();



            if(_FrozenSubscriptionInf.FreezeStartDate.Date<DateTime.Now.Date)
            {
                dtStartDate.Enabled = false;
            }
          
            dtStartDate.Value=_FrozenSubscriptionInf.FreezeStartDate;

            dtEndDate.Value = _FrozenSubscriptionInf.FreezeEndDate;



        }
        private void frmAddUpdateFrozenSubscription_Load(object sender, EventArgs e)
        {
            _DefaultValues();


            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {









        }

        private void label6_Click(object sender, EventArgs e)
        {

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
