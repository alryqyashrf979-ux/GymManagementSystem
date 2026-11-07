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
        public int EmployeeID { get { return this._EmployeeID; }}
        public int PersonID { get; set; }
        public int ShiftID { set; get; }
        public int TitleID { get; set; }
        public float Salary { get; set; }
        public DateTime HiredDate { set; get; }
        public DateTime? TerminationDate { set; get; }
        public string Notes { set; get; }
        public bool IsActive { set; get; }

        private clsPeople _Person;
        public clsPeople Person { get { return _Person; } }
        private clsEmployeeShift _EmployeeShift;
        public clsEmployeeShift EmployeeShift { get { return _EmployeeShift; } }
        public clsTitles TitleInfo { get; private set; }

        public enum enMode { AddMode=1,UpdateMode=2};
        enMode _Mode = enMode.AddMode;


        public clsEmployees()
        {
            this._EmployeeID = -1;
            this.PersonID = -1;
            this.ShiftID = -1;
            this.TitleID = -1;
            this.Salary = 0;

            this.HiredDate = DateTime.Now;
            this.Notes = string.Empty;
            this.IsActive = false;
            this._Person = new clsPeople();
            this._EmployeeShift =clsEmployeeShift.Find(ShiftID);
            this._Mode = enMode.AddMode;
        }
        //
        clsEmployees(int EmployeeID,int PersonID,int ShiftID,int TitleID,float Salary,DateTime HiredDate,DateTime? TerminationDate, string Notes,bool IsActive)
        {
            this._EmployeeID = EmployeeID;
            this.PersonID = PersonID;
            this.ShiftID = ShiftID;
            this.TitleID = TitleID;
            this.Salary = Salary;
            this.HiredDate = HiredDate;
            this.Notes = Notes;
            this.IsActive = IsActive;
            this._Person = clsPeople.Find(PersonID);
            this._EmployeeShift = clsEmployeeShift.Find(ShiftID);
            this.TitleInfo = clsTitles.Find(TitleID);
            this.TerminationDate = TerminationDate;
            _Mode = enMode.UpdateMode;
        }

        private bool _AddEmployee()
        {
            this._EmployeeID = clsEmployeesData.AddEmployee(this.PersonID, this.TitleID,this.Salary, this.Notes, this.IsActive, this.ShiftID);

            return this._EmployeeID != -1;
        }

        private bool _UpdateEmployee()
        {
            return clsEmployeesData.UpdateEmployee(this._EmployeeID, this.PersonID, this.TitleID, this.Salary, this.HiredDate, this.Notes, this.IsActive, this.ShiftID);
        }
        public static DataTable GetAllEmployees()
        {
            return clsEmployeesData.GetAllEmployees();
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

        static public clsEmployees FindByEmployeeID(int EmployeeID)
        {
            int PersonID = -1, ShiftID = -1;
            int TitleID = -1;string Notes=string.Empty;
            float Salary = 0;
            DateTime HiredDate = DateTime.Now;DateTime? TerminationDate = DateTime.Now;
            bool IsActive = false;                  //? to handle allows null

            bool IsFound = clsEmployeesData.FindByEmployeeID(EmployeeID,ref PersonID,ref TitleID,ref Salary,ref HiredDate,ref TerminationDate ,ref Notes,ref IsActive,ref ShiftID);
                                               
            if (IsFound)
                return new clsEmployees(EmployeeID, PersonID, ShiftID, TitleID, Salary, HiredDate,TerminationDate, Notes, IsActive);
            else
                return null;
        }


        static public clsEmployees FindByNationalNu(string NationalNu)
        {
            int PersonID = -1, ShiftID = -1;
            int TitleID = -1;string Notes = string.Empty;
            float Salary = 0;
            DateTime HiredDate = DateTime.Now; DateTime? TerminationDate = DateTime.Now;
            bool IsActive = false;                  //? to handle allows null
            int EmployeeID = -1;

            bool IsFound = clsEmployeesData.FindByNationalNu(NationalNu, ref PersonID, ref EmployeeID, ref TitleID, ref Salary, ref HiredDate, ref TerminationDate, ref Notes, ref IsActive, ref ShiftID);

            if (IsFound)
                return new clsEmployees(EmployeeID, PersonID, ShiftID, TitleID, Salary, HiredDate, TerminationDate, Notes, IsActive);
            else
                return null;
        }

        public bool IsCoach()
        {
            return clsCoaches.IsCoach(this.EmployeeID);
        }


        static public clsEmployees FindByPersonID(int PersonID)
        {
            int EmployeeID = -1, ShiftID = -1;
            int TitleID = -1;string Notes = string.Empty;
            float Salary = 0;
            DateTime HiredDate = DateTime.Now; DateTime? TerminationDate = DateTime.Now;
            bool IsActive = false;                  //? to handle allows null

            bool IsFound = clsEmployeesData.FindByEmployeeID(PersonID, ref EmployeeID, ref TitleID, ref Salary, ref HiredDate, ref TerminationDate, ref Notes, ref IsActive, ref ShiftID);

            if (IsFound)
                return new clsEmployees(EmployeeID, PersonID, ShiftID, TitleID, Salary, HiredDate,TerminationDate, Notes, IsActive);
            else
                return null;
        }
      
        static public bool TerminateEmployee(int EmployeeID)
        {
            return clsEmployeesData.TerminateEmployee(EmployeeID);
        }

    }
}
