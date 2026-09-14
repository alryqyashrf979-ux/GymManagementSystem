using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class clsUsers
    {


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int int_UserID = -1;
        public int UserID { set; get; }
        public int PersonID { get { return int_UserID; } }
        public clsPeople PersonInfo;
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public sbyte Permission {  set; get; }

        public clsUsers()

        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            this.Permission = 0;
            this.int_UserID = -1;

            Mode = enMode.AddNew;
        }

        private clsUsers(int UserID, int PersonID, string Username, string Password,sbyte Permission,
            bool IsActive)

        {
            this.UserID = UserID;
            this.int_UserID = PersonID;
            this.Permission = Permission;
            this.PersonInfo = clsPeople.Find(PersonID);
            this.UserName = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }



        private bool _AddNewUser()
        {
            //call DataAccess Layer 

            this.int_UserID = clsUsersData.AddNewUser(this.PersonID, this.UserName,
                this.Password,this.Permission,this.IsActive);

            return (this.int_UserID != -1);
        }
        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUsersData.UpdateUser(this.UserID, this.PersonID, this.UserName,
                this.Password,this.Permission ,this.IsActive);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }

            return false;
        }


        public static clsUsers FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            sbyte Permission = 0;
            bool IsActive = false;

            bool IsFound = clsUsersData.GetUserInfoByUserID
                                (UserID, ref PersonID, ref UserName, ref Password,ref Permission,ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUsers(UserID, PersonID, UserName, Password,Permission, IsActive);
            else
                return null;
        }
        public static clsUsers FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            sbyte Permission = 0;
            bool IsActive = false;

            bool IsFound = clsUsersData.GetUserInfoByPersonID(ref UserID,PersonID,ref UserName,ref Password,ref Permission,ref IsActive) ;
                               
            if (IsFound)
                //we return new object of that User with the right data
                return new clsUsers(UserID, UserID, UserName, Password,Permission, IsActive);
            else
                return null;
        }



        public static clsUsers FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            sbyte Permission = 0;

            bool IsActive = false;

            bool IsFound = clsUsersData.GetUserInfoByUsernameAndPassword
                                (UserName, Password, ref UserID, ref PersonID, ref IsActive,ref Permission);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUsers(UserID, PersonID, UserName, Password, Permission, IsActive);
            else
                return null;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUsersData.DeleteUser(UserID);
        }





    }
}
