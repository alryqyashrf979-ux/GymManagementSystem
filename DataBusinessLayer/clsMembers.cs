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
    public class clsMembers : clsPeople
    {
        public enum enModeMembers { add = 1, edit = 2 }
        public enModeMembers MembersMode = enModeMembers.add;
        private int _MemberID;
        public int MemberID { get { return _MemberID; } }

        public int personID { set; get; }
        public DateTime LastSubscriptionDate { set; get; }
        public bool IsActive { set; get; }
        public int ContactPersonInfoID { set; get; }

        clsEmergencyContacts EmergencyContactInfo { set; get; }

        public clsMembers() : base()
        {

            _MemberID = -1;
            personID = -1;
            LastSubscriptionDate = default(DateTime);
            IsActive = false;
            ContactPersonInfoID = -1;
            EmergencyContactInfo = null;
            MembersMode = enModeMembers.add;
        }
        public clsMembers(int MemberID, int personID, DateTime lastSubscriptionDate, bool IsActive, int ContactPersonInfoID, int PersonID, string FirstName, string SecondName,
            string LastName, string NationalNo, DateTime DateOfBirth, char Gender,
             string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath) : base(PersonID, FirstName, SecondName,
           LastName, NationalNo, DateOfBirth, Gender,
            Address, Phone, Email,
             NationalityCountryID, ImagePath)
        {
            this._MemberID = MemberID;
            this.personID = personID;
            this.LastSubscriptionDate = lastSubscriptionDate;
            this.IsActive = IsActive;
            this.ContactPersonInfoID = ContactPersonInfoID;
            this.EmergencyContactInfo = clsEmergencyContacts.Find(ContactPersonInfoID);
            MembersMode = enModeMembers.add;
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
            if (clsMembersDataAccess.Delete(memberID))
                if (clsPeople.DeletePerson(this.PersonID))
                    return true;
            return false;
        }
        private bool _Update()
        {
            return clsMembersDataAccess.Update(this.MemberID, this.personID, this.LastSubscriptionDate, this.IsActive, this.ContactPersonInfoID);

        }
        private bool _Add()
        {
            this._MemberID = clsMembersDataAccess.Add(this.PersonID, this.LastSubscriptionDate, this.IsActive, this.ContactPersonInfoID);
            return _MemberID != -1;
        }

        public bool Save()
        {
            base.Mode = (MembersMode == enModeMembers.add) ? enMode.AddNew : enMode.Update;
            if (!base.Save())
                return false;
            switch (MembersMode)
            {
                case enModeMembers.add:
                    {
                        if (_Add())
                            return true;
                        break;
                    }
                case enModeMembers.edit:
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
                clsPeople person = clsPeople.Find(personID);
                return new clsMembers(MemberID,personID,LastSubscriptionDate,IsActive,EmergencyContactID,personID,person.FirstName,person.SecondName,person.LastName
                    ,person.NationalNo,person.DateOfBirth,person.Gender,person.Address,person.PhoneNumber,person.Email,person.NationalityCountryID,person.ImagePath);
               
            }
            return null;
        }
        static public clsMembers FindMemberUsingMemberID(int memberID)
        {
            int PersonID = -1; int EmergencyContactID = -1; DateTime LastSubscriptionDate = default(DateTime); bool IsActive = false;
            if (clsMembersDataAccess.FindmemberByMemberID( memberID ,ref PersonID, ref LastSubscriptionDate, ref IsActive, ref EmergencyContactID))
            {
                clsPeople person = clsPeople.Find(PersonID);
                return new clsMembers(memberID, PersonID, LastSubscriptionDate, IsActive, EmergencyContactID, PersonID, person.FirstName, person.SecondName, person.LastName
                    , person.NationalNo, person.DateOfBirth, person.Gender, person.Address, person.PhoneNumber, person.Email, person.NationalityCountryID, person.ImagePath);

            }
            return null;
        }
    }
}

