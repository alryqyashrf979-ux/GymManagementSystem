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

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddEmployee())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UpdateMode:
                    return _UpdateEmployee();
            }
            return false;
        }

        static public object FindByEmployeeID(int EmployeeID)
        {
            int PersonID = -1, ShiftID = -1;
            string Title = string.Empty,Notes=string.Empty;
            float Salary = 0;
            DateTime HiredDate = DateTime.Now;DateTime? TerminationDate = DateTime.Now;
            bool IsActive = false;                  //? to handle allows null

            bool IsFound = clsEmployeesData.FindByEmployeeID(EmployeeID,ref PersonID,ref Title,ref Salary,ref HiredDate,ref TerminationDate ,ref Notes,ref IsActive,ref ShiftID);
                                               
            if (IsFound)
                return new clsEmployees(EmployeeID, PersonID, ShiftID, Title, Salary, HiredDate, Notes, IsActive);
            else
                return null;
        }

        static public object FindByPersonID(int PersonID)
        {
            int EmployeeID = -1, ShiftID = -1;
            string Title = string.Empty, Notes = string.Empty;
            float Salary = 0;
            DateTime HiredDate = DateTime.Now; DateTime? TerminationDate = DateTime.Now;
            bool IsActive = false;                  //? to handle allows null

            bool IsFound = clsEmployeesData.FindByEmployeeID(PersonID, ref EmployeeID, ref Title, ref Salary, ref HiredDate, ref TerminationDate, ref Notes, ref IsActive, ref ShiftID);

            if (IsFound)
                return new clsEmployees(EmployeeID, PersonID, ShiftID, Title, Salary, HiredDate, Notes, IsActive);
            else
                return null;
        }

        static public bool TerminateEmployee(int EmployeeID)
        {
            return clsEmployeesData.TerminateEmployee(EmployeeID);
        }

    }
}
