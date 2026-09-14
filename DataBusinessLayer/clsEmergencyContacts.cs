using System;
using System.Collections.Generic;
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








    }
}
