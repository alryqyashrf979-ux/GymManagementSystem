using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace DataBusinessLayer
{
    public class clsCoaches
    {
        private int _CoachID;
        public int CoachID { get; }
        public int EmployeeID { set; get; }
        public string Note { set; get; }
        public string Speciality { set; get; }
        private clsEmployees _Employees;
        public clsEmployees Employees { get { return _Employees; } }

        public enum enMode { AddMode=1,UpdateMode=2}
        private enMode _Mode = enMode.AddMode;

        public clsCoaches()
        {
            _CoachID = -1;
            EmployeeID = -1;
            Note = string.Empty;
            Speciality = string.Empty;
            _Mode = enMode.AddMode;
        }


    }
}
