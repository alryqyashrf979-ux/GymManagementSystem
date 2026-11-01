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


        public int MemberID { get; private set; } = -1;
        public clsMembers MemberInfo{ get; private set; }


        void _ResetMemberData()
        {
            uctPersonDetails1.ResetData();

            this.MemberID = -1;
     
        
      
        }


        void _LoadData()
        {
            uctPersonDetails1.LoadPersonInfo(MemberInfo.PersonID);
            ctrlMemberBasicDetails1.LoadMemberInfoByMemberID(MemberInfo.MemberID);
            this.MemberID = MemberInfo.MemberID;
 
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
