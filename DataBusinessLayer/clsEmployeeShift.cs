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

        public clsEmployeeShift()
        {
            _ShiftID = -1;
            this.ShiftType = string.Empty;
            this.StartTime = DateTime.Now;
            this.EndTime = DateTime.Now;
            _Mode = enMode.AddMode;
        }

        public clsEmployeeShift(int ShiftID,string ShiftType,DateTime StartTime,DateTime EndTime)
        {
            _ShiftID = ShiftID;
            this.ShiftType = ShiftType;
            this.StartTime = StartTime;
            this.EndTime =EndTime;
            _Mode = enMode.UpdateMode;
        }

        private bool _AddEmployeeShift()
        {
            _ShiftID = clsEmployeeShiftData.AddEmployeeShift(ShiftType, StartTime, EndTime);

            return _ShiftID != -1;
        }

        private bool _UpdateEmployeeShift()
        {
            return clsEmployeeShiftData.UpdateEmployeeShift(_ShiftID, ShiftType, StartTime, EndTime);
        }

        static public bool DeleteEmployeeShift(int ShiftID)
        {
            return clsEmployeeShiftData.DeleteEmployeeShift(ShiftID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddEmployeeShift())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UpdateMode:
                    return _UpdateEmployeeShift();
            }
            return false;
        }

    }
}
