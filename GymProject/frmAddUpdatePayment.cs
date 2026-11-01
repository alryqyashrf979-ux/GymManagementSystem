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
            if (ctrlMemberDetailsWithFiltering1.MemberID != -1)
            {
                btnSave.Enabled = true;
                tpPaymentInfo.Enabled = true;
                tcPayment.SelectedTab = tcPayment.TabPages["tpPaymentInfo"];
               ctrlPaymentDetails1.LoadPaymentInfo(clsPayments.SelectPaymentIDBySubscriptionID(ctrlMemberDetailsWithFiltering1.MemberInfo.LastSubscriptionID));
            }
            else
                MessageBox.Show("Select a member first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
