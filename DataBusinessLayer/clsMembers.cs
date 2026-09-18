using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class clsMembers 
    {
        public enum enMode{ add = 1, edit = 2 }
        public enMode Mode = enMode.add;
        private int _MemberID;
        public int MemberID { get { return _MemberID; } }

        public int PersonID { set; get; }
        public DateTime LastSubscriptionDate { set; get; }
        public bool IsActive { set; get; }
        public int ContactPersonInfoID { set; get; }

       public  clsEmergencyContacts EmergencyContactInfo { set; get; }
 public        clsPeople PersonInfo { set; get; }

        public clsMembers() 
        {

            _MemberID = -1;
            PersonID = -1;
            LastSubscriptionDate = default(DateTime);
            IsActive = false;
            ContactPersonInfoID = -1;
            EmergencyContactInfo = null;
            Mode = enMode.add;
            PersonInfo = null;
            Mode = enMode.add;
        }
        public clsMembers(int MemberID, int personID, DateTime lastSubscriptionDate, bool IsActive, int ContactPersonInfoID)
        { 
            this._MemberID = MemberID;
            this.PersonID = personID;
            this.LastSubscriptionDate = lastSubscriptionDate;
            this.IsActive = IsActive;
            this.ContactPersonInfoID = ContactPersonInfoID;
            this.EmergencyContactInfo = clsEmergencyContacts.Find(ContactPersonInfoID);
            this.PersonInfo = clsPeople.Find(PersonID);
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
        public bool Delete(int memberID)
        {
            return clsMembersDataAccess.Delete(memberID);
        }
        private bool _Update()
        {
            return clsMembersDataAccess.Update(this.MemberID, this.PersonID, this.LastSubscriptionDate, this.IsActive, this.ContactPersonInfoID);
        }
        private bool _Add()
        {
            this._MemberID = clsMembersDataAccess.Add(this.PersonID, this.LastSubscriptionDate, this.IsActive, this.ContactPersonInfoID);
            return _MemberID != -1;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.add:
                    {
                        if (_Add())
                            return true;
                        break;
                    }
                case enMode.edit:
                    if (_Update())
                        return true;
                    break;
            }
            return false;
        }
        static public clsMembers FindMemberUsingPersonID(int personID)
        {
            int MemberID = -1; int EmergencyContactID = -1; DateTime LastSubscriptionDate= default(DateTime); bool IsActive = false; 
            if(clsMembersDataAccess.FindmemberByPersonID(personID,ref MemberID , ref LastSubscriptionDate,ref IsActive,ref EmergencyContactID))
            {
                return new clsMembers(MemberID, personID, LastSubscriptionDate, IsActive, EmergencyContactID);               
            }
            return null;
        }
        static public clsMembers FindMemberUsingMemberID(int memberID)
        {
            int PersonID = -1; int EmergencyContactID = -1; DateTime LastSubscriptionDate = default(DateTime); bool IsActive = false;
            if (clsMembersDataAccess.FindmemberByMemberID( memberID ,ref PersonID, ref LastSubscriptionDate, ref IsActive, ref EmergencyContactID))
            {
                return new clsMembers(memberID, PersonID, LastSubscriptionDate, IsActive, EmergencyContactID);
            }
            return null;
        }
    }
}

