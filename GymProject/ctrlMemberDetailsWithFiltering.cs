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
    public partial class ctrlMemberDetailsWithFiltering : UserControl
    {
        public ctrlMemberDetailsWithFiltering()
        {
            InitializeComponent();
        }


        public void LoadMemberInfoByMemberID(int  memberID)
        {
            ctrlMemberBasicDetailsWithFilter1.LoadMemberInfoByMemberID(memberID);
        }

        private void ctrlMemberBasicDetailsWithFilter1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {


            if (e.MemberInfo == null)
                ctrlEmergencyContactDetails1.ResetEmergencyContactData();
            else
                ctrlEmergencyContactDetails1.LoadEmergencyContactInfo(e.MemberInfo.ContactID);





        }
    }
}
