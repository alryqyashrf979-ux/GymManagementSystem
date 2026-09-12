using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class clsPeople
    {



        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int int_PersonID=-1;
        public int PersonID { get { return int_PersonID; } }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + SecondName  + " " + LastName; }

        }
        public string NationalNo { set; get; }
        public DateTime DateOfBirth { set; get; }
        public char Gender { set; get; }
        public string Address { set; get; }
        public string PhoneNumber { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

        


        public clsPeople()

        {
            this.int_PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            this.NationalNo= "";
            this.Gender ='0';


            Mode = enMode.AddNew;
        }


        private clsPeople(int PersonID, string FirstName, string SecondName,
            string LastName, string NationalNo, DateTime DateOfBirth, char Gender,
             string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)

        {
            this.int_PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.PhoneNumber = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }





        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.int_PersonID = clsPeopleDataAccess.AddNewPerson(this.FirstName, this.SecondName,
                this.LastName, this.PhoneNumber, this.Gender, this.DateOfBirth, this.NationalityCountryID,
                this.Email, this.NationalNo, this.Address, this.ImagePath);

            return (this.int_PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPeopleDataAccess.UpdatePersonInfo(this.PersonID,this.FirstName, this.SecondName,
                this.LastName, this.PhoneNumber, this.Gender, this.DateOfBirth, this.NationalityCountryID,
                this.Email, this.NationalNo, this.Address, this.ImagePath);
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }


        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }

        public static bool DeletePerson(int ID)
        {
            return clsPeopleDataAccess.DeletePerson(ID);
        }

        public static bool isPersonExist(int ID)
        {
            return clsPeopleDataAccess.DoesPersonExist(ID);
        }

        public static bool isPersonExist(string NationlNo)
        {
            return clsPeopleDataAccess.DoesPersonExist(NationlNo);
        }

    }
}
