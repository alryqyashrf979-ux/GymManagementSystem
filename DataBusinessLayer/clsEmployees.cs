using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataBusinessLayer
{
    public class clsEmployees
    {
        private int _EmployeeID;
        public int EmployeeID { get; }
        public int PersonID { get; set; }
        public int ShiftID { set; get; }
        public string Title { get; set; }
        public float Salary { get; set; }
        public DateTime HiredDate { set; get; }
        public DateTime TerminationDate { set; get; }
        public string Notes { set; get; }
        public bool IsActive { set; get; }

        private object _Person;
        public object Person { get { return _Person; } }
        private object _Shift;
        public object Shift { get { return _Shift; } }

        public enum enMode { AddMode=1,UpdateMode=2};
        enMode _Mode = enMode.AddMode;
    }
}
