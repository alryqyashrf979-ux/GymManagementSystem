using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class frmAddUpdateMember : Form
    {
        public frmAddUpdateMember()
        {
            InitializeComponent();
            _Mode = enMode.Addnew;
        }

        private int _MemberID = -1;
        public frmAddUpdateMember(int memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
            _Mode = enMode.Update;
        }

        public event EventHandler<int> DataBack;


        enum enMode { Addnew = 1, Update = 2 };
        enMode _Mode = enMode.Addnew;


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {

                btnSave.Enabled = true;
                tpMemberInfo.Enabled = true;
                tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpMemberInfo"];
                return;
            }

            if(uctPersonDetailsWithFilter1.PersonID!=-1)
            {


                if (clsMembers.DoesMemberExistByPersonID(uctPersonDetailsWithFilter1.PersonID))
                {

                    MessageBox.Show("This person is already a member,Select another Person", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    tpMemberInfo.Enabled = false;
                    uctPersonDetailsWithFilter1.FocusOnTbSearch();


                }
                else
                {
                    btnSave.Enabled = true;
                    tpMemberInfo.Enabled = true;
                    tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpMemberInfo"];
                    lblPersonID.Text= uctPersonDetailsWithFilter1.PersonID.ToString();

                }




            }
            else
            {
                MessageBox.Show("Error : select a person or add a new person.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        clsMembers _Member;

        void _SetDefaultValues()
        {

            if(_Mode==enMode.Addnew)
            {
                lblTitle1.Text = "Add New Member";
                lblTitle2.Text = lblTitle1.Text;
                this.Text= lblTitle1.Text; 
                _Member = new clsMembers();

            }
   

            uctPersonDetailsWithFilter1.FocusOnTbSearch();
            txtInActivationReason.Text = string.Empty;
            txtPersonName.Text = string.Empty;
            lblMemberID.Text = "[???]";
            lblPersonID.Text = "[???]";
            txtPhoneNumber.Text = string.Empty;
            txtRelationship.Text= string.Empty;
            lblEmergencyContactID.Text = "[???]";

         

            btnSave.Enabled = false;
            tpMemberInfo.Enabled = false;
            tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpPersonalInfo"];
            tgschIsActive.Checked = true;

        }

        void _LoadDate()
        {

            _Member = clsMembers.FindMemberUsingMemberID(_MemberID);


            if (_Member == null)
            {

                MessageBox.Show($"Member with ID {_MemberID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblTitle2.Text = "Update Member";
            lblTitle1.Text = lblTitle2.Text;
            this.Text = lblTitle2.Text;

            uctPersonDetailsWithFilter1.DisableFiltering();
            txtPersonName.Text = _Member.EmergencyContactPersonName; ;
            txtRelationship.Text=_Member.Relationship;
            txtPhoneNumber.Text=_Member.EmergencyContactPersonName;
            tgschIsActive.Checked = _Member.IsActive;
            lblEmergencyContactID.Text = _Member.ContactID.ToString();
            lblPersonID.Text=uctPersonDetailsWithFilter1.PersonID.ToString();
            lblMemberID.Text = _Member.MemberID.ToString();
            txtInActivationReason.Text = _Member.InActivationReason;

            lnkAddSubscription.Enabled = false;
           


        }
        private void frmAddUpdateMember_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadDate();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _Member.IsActive = tgschIsActive.Checked;
            _Member.PersonID = uctPersonDetailsWithFilter1.PersonID;
            _Member.EmergencyContactPersonName = txtPersonName.Text;
            _Member.Relationship = txtRelationship.Text;    
            _Member.EmergencyContactPhoneNumber = txtPhoneNumber.Text;
            _Member.InActivationReason = txtInActivationReason.Text;



            if(_Member.Save())
            {

                lblTitle1.Text = "Update Member";
                lblTitle2.Text = lblTitle1.Text;
                this.Text = lblTitle1.Text;
                lblMemberID.Text = _Member.MemberID.ToString();
                lblEmergencyContactID.Text = _Member.ContactID.ToString();
                uctPersonDetailsWithFilter1.DisableFiltering();

                DataBack?.Invoke(this, _Member.MemberID);

                MessageBox.Show("Member saved successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);


                lnkAddSubscription.Enabled = (_Mode == enMode.Addnew);
                _Mode = enMode.Update;


            }
            else
                MessageBox.Show("Error : Member did Not save successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }


        void AddedSubscription(object Sender,clsSubscription AddedSusbcription )
        {
           _Member.LastSubscriptionID= AddedSusbcription.SubscriptionID;
            lnkAddSubscription.Enabled = false;
            MessageBox.Show($"Subscription Added Successfully with ID [{AddedSusbcription.SubscriptionID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInActivationReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkAddSubscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddSubscription frm = new frmAddSubscription();
            frm.AddedSubscription += AddedSubscription;
            frm.LoadMemberDetails(_Member.MemberID);
            frm.ShowDialog();
        }
    }
}
