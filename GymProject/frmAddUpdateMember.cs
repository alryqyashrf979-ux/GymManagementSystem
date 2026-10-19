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



        enum enMode { Addnew = 1, Update = 2 };
        enMode _Mode = enMode.Addnew;


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {

                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpLoginInfo"];
                return;
            }

            if(uctPersonDetailsWithFilter1.PersonID!=-1)
            {


                if (clsMembers.DoesMemberExistByPersonID(uctPersonDetailsWithFilter1.PersonID))
                {

                    MessageBox.Show("This person is already a member,Select another Person", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    tpLoginInfo.Enabled = false;
                    uctPersonDetailsWithFilter1.FocusOnTbSearch();


                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpLoginInfo"];
                    lblPersonID.Text= uctPersonDetailsWithFilter1.PersonID.ToString();

                }




            }
            else
            {
                MessageBox.Show("Please select a person or add a new person.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }







        }

        clsMembers _Member;

        void _SetDefaultValues()
        {

            if(_Mode==enMode.Addnew)
            {
                lblTitle1.Text = "Add New Member";
                lblTitle2.Text = "Add New Member";
                this.Text="Add New Member"; 
                _Member = new clsMembers();

            }
            else
            {
                lblTitle2.Text = "Update Member";
                lblTitle1.Text = "Update Member";
                this.Text = "Update Member";


            }

            txtPersonName.Text = string.Empty;
            lblMemberID.Text = "???";
            lblPersonID.Text = "???";
            txtPhoneNumber.Text = string.Empty;
            txtRelationship.Text= string.Empty;
            lblEmergencyContactID.Text = "???";

            dtLastSubscriptionDate.MaxDate = DateTime.Today;
            dtLastSubscriptionDate.MinDate = DateTime.Today;

            btnSave.Enabled = false;
            tpLoginInfo.Enabled = false;
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
            uctPersonDetailsWithFilter1.DisableFiltering();
            txtPersonName.Text = _Member.EmergencyContactInfo.Name;
            txtRelationship.Text=_Member.EmergencyContactInfo.Relationship;
            txtPhoneNumber.Text=_Member.EmergencyContactInfo.PhoneNumber;
            tgschIsActive.Checked = _Member.IsActive;
            lblEmergencyContactID.Text = _Member.EmergencyContactID.ToString();
            lblPersonID.Text=uctPersonDetailsWithFilter1.PersonID.ToString();
            lblMemberID.Text = _Member.MemberID.ToString();



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
      
















        }
    }
}
