using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class ctrlMemberDetailsWithFiltering : UserControl
    {
        public ctrlMemberDetailsWithFiltering()
        {
            InitializeComponent();
        }



        public int MemberID
        {
            get => ctrlMemberBasicDetailsWithFilter1.MemberID;
        }

        public clsMembers MemberInfo
        {
            get => ctrlMemberBasicDetailsWithFilter1.MemberInfo;
        }

      

        public bool EnableFiltering
        {

            set
            {
                ctrlMemberBasicDetailsWithFilter1.EnableFiltering = value;
            }

            get
            {
                return ctrlMemberBasicDetailsWithFilter1.EnableFiltering; 
            }

        }

        public event EventHandler<ctrlMemberBasicDetailsWithFilter.MemberEventArgs> OnMemberSelected;

        public new void Focus()
        {
            ctrlMemberBasicDetailsWithFilter1.Focus();
        }


        public void LoadMemberInfoByMemberID(int  memberID)
        {
            ctrlMemberBasicDetailsWithFilter1.LoadMemberInfoByMemberID(memberID);
        }

        private void ctrlMemberBasicDetailsWithFilter1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {


            OnMemberSelected?.Invoke(this, e);


            if (e.MemberInfo == null)
                ctrlEmergencyContactDetails1.ResetEmergencyContactData();
            else
            {
                ctrlEmergencyContactDetails1.LoadEmergencyContactInfo(e.MemberInfo.ContactID);
            }




        }
    }
}
