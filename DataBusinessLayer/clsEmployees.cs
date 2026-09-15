using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

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


        public clsEmployees()
        {
            _EmployeeID = -1;
            PersonID = -1;
            ShiftID = -1;
            Title = string.Empty;
            Salary = 0;
            HiredDate = DateTime.Now;
            Notes = string.Empty;
            IsActive = false;
            _Person = null;
            _Shift = null;
            _Mode = enMode.AddMode;
        }

        clsEmployees(int EmployeeID,int PersonID,int ShiftID,string Title,float Salary,DateTime HiredDate,string Notes,bool IsActive)
        {
            this._EmployeeID = EmployeeID;
            this.PersonID = PersonID;
            this.ShiftID = ShiftID;
            this.Title = Title;
            this.Salary = Salary;
            this.HiredDate = HiredDate;
            this.Notes = Notes;
            this.IsActive = IsActive;
            this._Person = clsPeople.Find(PersonID);
            this._Shift = null;//still has a shift class
            _Mode = enMode.UpdateMode;
        }

        private bool _AddEmployee()
        {
            _EmployeeID = clsEmployeesData.AddEmployee(PersonID, Title, Salary, Notes, IsActive, ShiftID);

            return _EmployeeID != -1;
        }

        private bool _UpdateEmployee()
        {
            return clsEmployeesData.UpdateEmployee(this._EmployeeID, this.PersonID, this.Title, this.Salary, this.HiredDate, this.Notes, this.IsActive, this.ShiftID);
        }

        static public bool DeleteEmployee(int EmployeeID)
        {
            return clsEmployeesData.DeleteEmployee(EmployeeID);
        }
    }
}
