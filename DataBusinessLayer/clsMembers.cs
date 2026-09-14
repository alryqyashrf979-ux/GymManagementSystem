using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
     public class clsMembers : clsPeople 
    {
        enum enMode { add =1 , edit = 2}
        enMode Mode = enMode.add;
        private int _MemberID;
        public int MemberID { get { return _MemberID; } }

        public int personID { set; get; }
        public DateTime LastSubscriptionID { set; get; }
        public bool IsActive { set; get; } 
        public int ContactPersonInfoID { set; get; }

        clsEmergencyContacts EmergencyContactInfo { set; get; }

        public clsMembers():base(){

            _MemberID = -1;
            personID = -1;
            LastSubscriptionID = default(DateTime);
            IsActive = false;
            ContactPersonInfoID = -1;
            EmergencyContactInfo = null;
            Mode = enMode.add;
        }
        public clsMembers(int MemberID ,int personID , DateTime lastSubscriptionDate , bool IsActive , int ContactPersonInfoID ,int PersonID, string FirstName, string SecondName,
            string LastName, string NationalNo, DateTime DateOfBirth, char Gender,
             string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath) : base( PersonID, FirstName,  SecondName,
           LastName,  NationalNo,  DateOfBirth, Gender,
            Address,  Phone,  Email,
             NationalityCountryID,  ImagePath)
        {
           this. _MemberID = MemberID;
            this.personID = personID;
           this. LastSubscriptionID = lastSubscriptionDate;
           this. IsActive = IsActive;
           this. ContactPersonInfoID = ContactPersonInfoID;
            this.EmergencyContactInfo = clsEmergencyContacts.Find(ContactPersonInfoID);
            Mode = enMode.edit;
        }

        static public DataTable GetAllMembers()
        {
            return clsMembersDataAccess.GetAllMembers();
        }

        static public bool DoesMemberExistByPersonID(int PersonID)
        {
            return clsMembersDataAccess.DoesPersonExistByPersonID(PersonID);
        }
        static public bool DoesMemberExistByMemberID(int MemberID)
        {
            return clsMembersDataAccess.DoesPersonExistByMemberID(MemberID);
        }




    }
}
