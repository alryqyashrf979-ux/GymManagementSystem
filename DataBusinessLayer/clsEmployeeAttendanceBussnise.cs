using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace DataBusinessLayer
{
    public class clsEmployeeAttendanceBussnise
    {
        private int _AttendanceID;
        public int AttendanceID { get { return _AttendanceID; } }
        public int EmployeeID { set; get; }
        public bool IsCheckin { set; get; }
        public bool IsCheckout { set; get; }
        public DateTime Date { set; get; }
        public string Note { set; get; }

       public enum enMode { AddMode=1,UpdateMode=2 }
        enMode _Mode = enMode.AddMode;

      public  clsEmployeeAttendanceBussnise()
        {
            _AttendanceID = -1;
            EmployeeID = -1;
            IsCheckin = false;
            IsCheckout = false;
            Date = DateTime.Now;
            Note = string.Empty;
            _Mode = enMode.AddMode;
        }


        clsEmployeeAttendanceBussnise(int AttendaceID, int EmployeeID, bool IsCheckin, bool IsCheckout, DateTime Date, string Note)
        {
            this._AttendanceID = AttendaceID;
            this.EmployeeID = EmployeeID;
            this.IsCheckin = IsCheckin;
            this.IsCheckout = IsCheckout;
            this.Date = Date;
            this.Note = Note;
            _Mode = enMode.UpdateMode;
        }

        static public DataTable GetAllEmployeeAttendance()
        {
            return clsEmployeeAttendanceData.GetAllEmployeeAttendenceData();
        }

        static public bool DeleteEmployeeAttendance(int AttendanceID)
        {
            return clsEmployeeAttendanceData.DeleteEmployeeAttendanceData(AttendanceID);
        }

        private bool _AddEmployeeAttendance()
        {
            _AttendanceID = clsEmployeeAttendanceData.AddEmployeeAttendanceData(EmployeeID, IsCheckin, IsCheckout, Note, Date);

            return (_AttendanceID != -1);
        }

        private bool _UpdateEmployeeAttendance()
        {
            return clsEmployeeAttendanceData.UpdateEmployeeAttendanceData(this._AttendanceID, this.EmployeeID, this.IsCheckin, this.IsCheckout, this.Note, this.Date);

        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddEmployeeAttendance())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.UpdateMode:
                    return _UpdateEmployeeAttendance();
            }
            return false;
        }
    }
}
