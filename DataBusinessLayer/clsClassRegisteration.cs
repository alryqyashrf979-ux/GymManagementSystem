using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{

    public class clsClassRegisteration
    {
        private int _ClassRegisterationID = -1;
        public int ClassRegisterationID { get { return _ClassRegisterationID; } }
        public int MemberID { get; set; }
        public int ClassID { get; set; }
        public int RegisteredByUserID { get; set; }
        public DateTime RegisterationDate { get; set; }
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public clsUsers UserInfo = new clsUsers();
        public clsClasses ClassInfo = new clsClasses();
        public clsMembers MemberInfo = new clsMembers();

        public clsClassRegisteration()
        {
            this._ClassRegisterationID = -1;
            this.MemberID = -1;
            this.ClassID = -1;
            this.RegisteredByUserID = -1;
            this.RegisterationDate = DateTime.Now;
            this.Mode = enMode.AddNew;
            UserInfo = new clsUsers();
            ClassInfo = new clsClasses();
            MemberInfo = new clsMembers();
        }

        private clsClassRegisteration(int ClassRegisterationID, int MemberID, int ClassID, int UserID, DateTime RegisterationDate)
        {
            this._ClassRegisterationID = ClassRegisterationID;
            this.MemberID = MemberID;
            this.ClassID = ClassID;
            this.RegisteredByUserID = UserID;
            this.RegisterationDate = RegisterationDate;
            this.Mode = enMode.Update;
            UserInfo = clsUsers.FindByUserID(RegisteredByUserID);
            ClassInfo = clsClasses.GetClassInfoByClassID(ClassID);
            MemberInfo = clsMembers.FindMemberUsingMemberID(MemberID);
        }

        static public DataTable GetAllClassRegisterationInfo()
        {
            return clsClassregisterationsDataAccess.GetAllClassRegisterationInfo();
        }

        static public DataTable FilterClassRegisterationByMemberID(int MemberID)
        {
            return clsClassregisterationsDataAccess.FilterClassRegisterationByMemberID(MemberID);
        }

        static public DataTable FilterClassRegisterationByClassID(int ClassID)
        {
            return clsClassregisterationsDataAccess.FilterClassRegisterationByClassID(ClassID);
        }

        static public bool Delete(int ClassRegisterationID)
        {
            return clsClassregisterationsDataAccess.Delete(ClassRegisterationID);
        }
    }
    }
