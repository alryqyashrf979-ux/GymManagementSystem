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

        public string Name { get; set; }
        public string Relationship { get; set; }
        public string PhoneNumber { get; set; }

        private int int_ContactID = -1;
        public int ContactID
        {
            get { return int_ContactID; }
        }

        public enum enMode { Update=1,AddNew=2}
        public enMode Mode = enMode.AddNew;


        private clsEmergencyContacts(string name, string relationship, string phoneNumber, int contactID)
        {
            Name = name;
            Relationship = relationship;
            PhoneNumber = phoneNumber;
            int_ContactID = contactID;
        }

        public clsEmergencyContacts()
        {
            Name = string.Empty;
            Relationship = string.Empty;
            PhoneNumber = string.Empty;
            int_ContactID = -1;
        }

        private bool _AddNewContact()
        {

            this.int_ContactID = clsEmergencyContactsData.AddEmergencyContact(this.Name, this.Relationship, this.PhoneNumber);
            return this.int_ContactID != -1;

        }

        private bool _UpdateContact()
        {
            return clsEmergencyContactsData.UpdateEmergencyContact(this.ContactID, this.Name, this.Relationship, this.PhoneNumber);
        }   


        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
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

        public static bool DeleteEmergencyContact(int contactID)
        {
            return clsEmergencyContactsData.DeleteEmergencyContact(contactID);
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
