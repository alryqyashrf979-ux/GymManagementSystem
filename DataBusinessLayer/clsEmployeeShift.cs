using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace DataBusinessLayer
{
   public class clsEmployeeShift
    {

        private int _ShiftID;
        public int ShiftID { get { return _ShiftID; } }
        public string ShiftType { set; get; }
        public DateTime StartTime { set; get; }
        public DateTime EndTime { set; get; }

        public enum enMode { AddMode=1,UpdateMode=2 }
        private enMode _Mode = enMode.AddMode;


    }
}
