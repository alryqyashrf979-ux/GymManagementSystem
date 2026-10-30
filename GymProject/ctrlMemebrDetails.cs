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
    public partial class ctrlMemebrDetails : UserControl
    {
        public ctrlMemebrDetails()
        {
            InitializeComponent();
        }

     
        public int MemberID{ get;private set;}
        public clsMembers MemberInfo{ get; private set; }


        void _ResetMemberData()
        {
            uctPersonDetails1.ResetData();

            this.MemberID = -1;
            txtInActivationReason.Text= string.Empty;
            lblEmergencyContactID.Text = "[????]";
            lblEmergencyContactPhone.Text = "[????]";
            lblLastSubscriptionID.Text = "[????]";
            lblMemberID.Text = "[????]";
            lblRelationship.Text = "[????]";
            lblEmergencyContactPersonName.Text = "[????]";
            tgschIsActive.Checked = true;
        }


        void _LoadData()
        {
            uctPersonDetails1.LoadPersonInfo(MemberInfo.PersonID);
            this.MemberID = MemberInfo.MemberID;
            lblEmergencyContactID.Text = MemberInfo.ContactID.ToString();
            lblEmergencyContactPersonName.Text = MemberInfo.EmergencyContactPersonName;
            lblEmergencyContactPhone.Text = MemberInfo.EmergencyContactPhoneNumber;
            lblLastSubscriptionID.Text=MemberInfo.LastSubscriptionID.ToString();
            lblMemberID.Text=MemberInfo.MemberID.ToString();
            lblRelationship.Text = MemberInfo.Relationship;
            tgschIsActive.Checked = MemberInfo.IsActive;
            txtInActivationReason.Text = MemberInfo.InActivationReason;

            lnkShowLastSubscriptionInfo.Enabled = (MemberInfo.LastSubscriptionID != -1);

        }


        public void LoadMemberInfoByMemberID(int MemberID )
        {
            MemberInfo=clsMembers.FindMemberUsingMemberID( MemberID );

            if (MemberInfo == null)
            {
                _ResetMemberData();
                MessageBox.Show("No Member with Member ID=" + MemberID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }


        public void LoadMemberInfoByPersonID(int PersonID )
        {
            MemberInfo=clsMembers.FindMemberUsingPersonID( PersonID );

            if (MemberInfo == null)
            {
                _ResetMemberData();
                MessageBox.Show("No Member with Person ID=" + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }
        public void LoadMemberInfoByNationalNu(string NationalNu )
        {
            MemberInfo=clsMembers.FindMemberUsingNationalNu( NationalNu );

            if (MemberInfo == null)
            {
                _ResetMemberData();
                MessageBox.Show("No Member with National Nu=" + NationalNu.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }


        private void lnkShowLastSubscriptionInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Not Emplemented...");
        }

      
    }
}
