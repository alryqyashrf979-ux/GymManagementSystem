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
        public int MemberID { get; set; }
        public int ClassID { get; set; }
        public int RegisteredByUserID { get; set; }
        public DateTime RegisterationDate { get; set; }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public clsUsers UserInfo = new clsUsers();
        public clsClasses ClassInfo = new clsClasses();
        public clsMembers MemberInfo = new clsMembers();
    }
    }
