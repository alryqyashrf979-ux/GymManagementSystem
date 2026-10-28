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
    public partial class frmAddSubscription : Form
    {
        public frmAddSubscription()
        {
            InitializeComponent();
        }
        public enum enMode { AddMode, UpdateMode }
        enMode _Mode = enMode.AddMode;
        private void frmAddSubscription_Load(object sender, EventArgs e)
        {
            ctrlSubscriptionPlanDetailsWithFiltering1.LoadAvailabilityPlanNames();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateMode)
            {
                btnSave.Enabled = true;
                tpSubscriptionInfo.Enabled = true;
                tcSubscriptionInfo.SelectedTab = tcSubscriptionInfo.TabPages["tpSubscriptionInfo"];
                return;
            }

            if (ctrlMemberDetailsWithFiltering1.MemberID != -1)
            {
                //if (clsSubscription.d)
                //{
                //    MessageBox.Show("Selected Member already has an Existingw Subscription, choose another one.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    ctrlMemberDetailsWithFiltering1.Focus();
                //}
                //else
                //{
                //    btnSave.Enabled = true;
                //    tpSubscriptionInfo.Enabled = true;
                //    //lblPersonID.Text = uctPersonDetailsWithFilter1.PersonID.ToString();
                //    tcSubscriptionInfo.SelectedTab = tcSubscriptionInfo.TabPages["tpSubscriptionInfo"];

                //}
            }
            else
            {
                MessageBox.Show("Please Select a Member", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlMemberDetailsWithFiltering1.Focus();
            }
        }
    }
}
