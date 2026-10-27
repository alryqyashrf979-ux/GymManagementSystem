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

        clsMembers _MemberInfo; 



        public clsMembers MemberInfo
        {
            get => _MemberInfo;
        }


        void _ResetMemberData()
        {
            uctPersonDetails1.ResetData();


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
            uctPersonDetails1.LoadPersonInfo(_MemberInfo.PersonID);
            lblEmergencyContactID.Text = _MemberInfo.ContactID.ToString();
            lblEmergencyContactPersonName.Text = _MemberInfo.EmergencyContactPersonName;
            lblEmergencyContactPhone.Text = _MemberInfo.EmergencyContactPhoneNumber;
            lblLastSubscriptionID.Text=_MemberInfo.LastSubscriptionID.ToString();
            lblMemberID.Text=_MemberInfo.MemberID.ToString();
            lblRelationship.Text = _MemberInfo.Relationship;
            tgschIsActive.Checked = _MemberInfo.IsActive;
            txtInActivationReason.Text = _MemberInfo.InActivationReason;

            lnkShowLastSubscriptionInfo.Enabled = (_MemberInfo.LastSubscriptionID != -1);

        }


        public void LoadMemberInfoByMemberID(int MemberID )
        {
            _MemberInfo=clsMembers.FindMemberUsingMemberID( MemberID );

            if (_MemberInfo == null)
            {
                _ResetMemberData();
                MessageBox.Show("No Member with Member ID=" + MemberID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }


        public void LoadMemberInfoByPersonID(int PersonID )
        {
            _MemberInfo=clsMembers.FindMemberUsingPersonID( PersonID );

            if (_MemberInfo == null)
            {
                _ResetMemberData();
                MessageBox.Show("No Member with Person ID=" + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }
        public void LoadMemberInfoByNationalNu(string NationalNu )
        {
            _MemberInfo=clsMembers.FindMemberUsingNationalNu( NationalNu );

            if (_MemberInfo == null)
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
