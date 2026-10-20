using DataAccessLayer;
using System;
using System.CodeDom;
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
    public class clsMembers : clsEmergencyContacts
    {
        private enum enMode{ add = 1, edit = 2 }
        private enMode _Mode = enMode.add;
        private int _MemberID;
        public int MemberID { get { return _MemberID; } }

        public int PersonID { set; get; }
        public int LastSubscriptionID { set; get; }
        public bool IsActive { set; get; }
        public clsPeople PersonInfo { set; get; }

        public clsMembers():base()
        {

            _MemberID = -1;
            PersonID = -1;
            LastSubscriptionID = -1;
            IsActive = false;
            _Mode = enMode.add;
            PersonInfo = null;
            _Mode = enMode.add;
        }
        public clsMembers(int MemberID, int personID, int lastSubscriptionID, bool IsActive, int EmergencyContactID,string ContactName,string ContactPhone,string Relationship):
                                                                                                                      base(ContactName,Relationship,ContactPhone, EmergencyContactID)
        { 
            this._MemberID = MemberID;
            this.PersonID = personID;
            this.LastSubscriptionID = lastSubscriptionID;
            this.IsActive = IsActive;
            this.PersonInfo = clsPeople.Find(PersonID);
            _Mode = enMode.edit;
        }

        static public DataTable GetAllMembers()
        {
            return clsMembersDataAccess.GetAllMembers();
        }

        static public bool DoesMemberExistByPersonID(int PersonID)
        {
            return clsMembersDataAccess.DoesMemberExistByPersonID(PersonID);
        }
        static public bool DoesMemberExistByMemberID(int MemberID)
        {
            return clsMembersDataAccess.DoesMemberExistByMemberID(MemberID);
        }
        public bool Delete()
        {
            if (clsMembersDataAccess.Delete(this.MemberID))
                return base.DeleteEmergencyContact();
            else
                return false;
        }
        private bool _Update()
        {
            return clsMembersDataAccess.Update(this.MemberID, this.PersonID, this.LastSubscriptionID, this.IsActive, this.ContactID);
        }
        private bool _Add()
        {
            this._MemberID = clsMembersDataAccess.Add(this.PersonID, this.LastSubscriptionID, this.IsActive, this.ContactID);
            return _MemberID != -1;
        }
        public new bool Save()
        {

            base.Mode = (clsEmergencyContacts.enMode)_Mode;

            if (!base.Save())
                return false;


            switch (_Mode)
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
        public bool Subscription(DateTime StartDate ,clsSubscription.enSubscriptionStatus Status,int SubscriptionPlanID,int CreatedByUser)
        {

            if (this.MemberID != -1)
            {

                clsSubscriptionPlans subscriptionPlan = clsSubscriptionPlans.Find(SubscriptionPlanID);

                if (subscriptionPlan == null)
                    return false;

                clsSubscription subscription = new clsSubscription();
                subscription.MemberID = this.MemberID;
                subscription.PlanID = SubscriptionPlanID;
                subscription.Price = subscriptionPlan.PlanPrice;
                subscription.StartDate = StartDate;
                subscription.ExpirationDate = DateTime.Now.AddYears(subscriptionPlan.Duration);
                subscription.createdByUserID = CreatedByUser;
                subscription.Status = Status;





            }
            else
                return false;

            



        }




        static public clsMembers FindMemberUsingPersonID(int personID)
        {
            int MemberID = -1; int EmergencyContactID = -1; int LastSubscriptionID=-1; bool IsActive = false;

            bool IsFound = clsMembersDataAccess.FindmemberByPersonID(personID, ref MemberID, ref LastSubscriptionID, ref IsActive, ref EmergencyContactID);


            if (IsFound)
            {

                clsEmergencyContacts ContactInfo = clsEmergencyContacts.Find(EmergencyContactID);



                return new clsMembers(MemberID, personID, LastSubscriptionID, IsActive,ContactInfo.ContactID,
                    ContactInfo.EmergencyContactPersonName,ContactInfo.EmergencyContactPhoneNumber,ContactInfo.Relationship);               
            }
            return null;
        }
        static public clsMembers FindMemberUsingMemberID(int memberID)
        {
            int PersonID = -1; int EmergencyContactID = -1; int LastSubscriptionID = -1; bool IsActive = false;

            bool IsFound = clsMembersDataAccess.FindmemberByMemberID(memberID, ref PersonID, ref LastSubscriptionID, ref IsActive, ref EmergencyContactID);

            if (IsFound)
            {

                clsEmergencyContacts ContactInfo = clsEmergencyContacts.Find(EmergencyContactID);



                return new clsMembers(memberID, PersonID, LastSubscriptionID, IsActive, ContactInfo.ContactID,
                    ContactInfo.EmergencyContactPersonName, ContactInfo.EmergencyContactPhoneNumber, ContactInfo.Relationship);
            }
            return null;
        }
    }
}

