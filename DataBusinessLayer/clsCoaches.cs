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
        public int CoachID { get { return this._CoachID; } }
        public int EmployeeID { set; get; }
        public string Note { set; get; }
        public string Speciality { set; get; }
        private clsEmployees _Employees;
        public clsEmployees Employees { get { return _Employees; } }
        public DateTime HiredDate { get; set; }
        public enum enMode { AddMode=1,UpdateMode=2}
        private enMode _Mode = enMode.AddMode;

        public clsCoaches()
        {
            _CoachID = -1;
            EmployeeID = -1;
            Note = string.Empty;
            Speciality = string.Empty;
            HiredDate = DateTime.Now;
            _Mode = enMode.AddMode;
        }

        public clsCoaches(int CoachID,int EmployeeID,string Note,string Speciality,DateTime HiredDate)
        {
            this._CoachID = CoachID;
            this.EmployeeID = EmployeeID;
            this.Note = Note;
            this.Speciality = Speciality;
            this.HiredDate = HiredDate;
            _Employees = clsEmployees.FindByEmployeeID(EmployeeID);
            _Mode = enMode.UpdateMode;
        }

        private bool _AddCoach()
        {
            _CoachID = clsCoachData.AddCoach(this.EmployeeID, this.Speciality, this.Note);

            return _CoachID != -1;
        }


        private bool _UpdateCoach()
        {
            return clsCoachData.UpdateCoach(this._CoachID, this.EmployeeID, this.Speciality, this.Note);
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddCoach())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateCoach();
            }
            return false;
        }

        static public bool DeleteCoach(int CoachID)
        {
            return clsCoachData.DeleteCoach(CoachID);
        }

        public static DataTable GetAllCoaches()
        {
            return clsCoachData.GetAllCoaches();
        }


        static public clsCoaches FindByCoachID(int CoachID)
        {
            int EmployeeID = -1;
            DateTime HiredDate = DateTime.Now;
            string Note = string.Empty, Speciality = string.Empty;

            bool IsFound = clsCoachData.FindByCoachID(CoachID, ref EmployeeID, ref Speciality, ref Note,ref HiredDate);

            if (IsFound)
                return new clsCoaches(CoachID, EmployeeID, Note, Speciality,HiredDate);
            else
                return null;
        }


        public static bool IsCoach(int EmployeeID)
        {
            return clsCoachData.IsCoach(EmployeeID);
        }

        static public clsCoaches FindByEmployeeID(int EmployeeID)
        {
            int CoachID = -1;
            DateTime HiredDate = DateTime.Now;
            string Note = string.Empty, Speciality = string.Empty;

            bool IsFound = clsCoachData.FindByEmployeeID(EmployeeID, ref CoachID, ref Speciality, ref Note,ref HiredDate);

            if (IsFound)
                return new clsCoaches(CoachID, EmployeeID, Note, Speciality,HiredDate);
            else
                return null;
        }

        static public int SelectTotalClassesForCoach(int CoachID)
        {
            return clsCoachData.SelectTotalClassesForCoach(CoachID);
        }
    }
}
