using System;
using System.Collections.Generic;
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


















    }
}
