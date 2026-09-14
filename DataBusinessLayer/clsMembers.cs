using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
     public class clsMembers : clsPeople 
    {
        private int _MemberID;
        public int MemberID { get { return _MemberID; } }

        public int personID { set; get; }
        public DateTime LastSubscriptionID { set; get; }
        public bool IsActive { set; get; } 
        public int ContactPersonInfoID { set; get; }

        clsEmergencyContacts EmergencyContactInfo { set; get; }


    }
}
