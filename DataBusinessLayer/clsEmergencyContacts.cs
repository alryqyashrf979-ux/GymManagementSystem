using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class clsEmergencyContacts
    {

        public string EmergencyContactPersonName { get; set; }
        public string Relationship { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }

        private int _ContactID = -1;
        public int ContactID
        {
            get { return _ContactID; }
        }

        public enum enMode { Update=2,Add=1}
        public enMode Mode = enMode.Add;


        protected clsEmergencyContacts(string name, string relationship, string phoneNumber, int contactID)
        {
            EmergencyContactPersonName = name;
            Relationship = relationship;
            EmergencyContactPhoneNumber = phoneNumber;
            _ContactID = contactID;

            Mode=enMode.Update;
        }

        public clsEmergencyContacts()
        {
            EmergencyContactPersonName = string.Empty;
            Relationship = string.Empty;
            EmergencyContactPhoneNumber = string.Empty;
            _ContactID = -1;

            Mode = enMode.Add;

        }

        private bool _AddNewContact()
        {

            this._ContactID = clsEmergencyContactsData.AddEmergencyContact(this.EmergencyContactPersonName, this.Relationship, this.EmergencyContactPhoneNumber);
            return this._ContactID != -1;

        }

        private bool _UpdateContact()
        {
            return clsEmergencyContactsData.UpdateEmergencyContact(this.ContactID, this.EmergencyContactPersonName, this.Relationship, this.EmergencyContactPhoneNumber);
        }   


        public bool Save()
        {

            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewContact())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateContact();

            }

            return false;

        }

        public  bool DeleteEmergencyContact()
        {
            return clsEmergencyContactsData.DeleteEmergencyContact(this.ContactID);
        }

        public static DataTable GetAllEmergencyContacts()
        {
            return clsEmergencyContactsData.GetAllEmergencyContacts();
        }


        public static clsEmergencyContacts Find(int ContactID)
        {

            string Name = string.Empty;
            string PhoneNumber = string.Empty;
            string Relationship = string.Empty;


            if (clsEmergencyContactsData.GetEmergencyContactByID(ContactID, ref Name, ref Relationship, ref PhoneNumber))
            {

                return new clsEmergencyContacts(Name, Relationship, PhoneNumber, ContactID);

            }
            else
                return null;

        }




    }
}
