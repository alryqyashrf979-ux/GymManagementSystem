using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class ClassesDataBusiness
    {

        public int ClassID { get; set; }
        public string className { get; set; }
        public string Description { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Note { get; set; }
        public byte Maximum_Capacity { get; set; }
        public bool IsActive { get; set; }
        public string StartDay { get; set; }
        public string EndDay { get; set; }
        public int CoachID { get; set; }


        private enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.AddNew;



        //  Implemented a private `AddClass()` method to handle adding new
        //classes via
        private bool _AddClass()
        {
            this.ClassID = DataAccessLayer.ClassesDataAccess.AddNewClass(this.CoachID, this.className, this.Description, this.StartTime,
                this.EndTime, this.Note,
                this.Maximum_Capacity, this.IsActive, this.StartDay, this.EndDay);

            return (this.ClassID != -1);
        }
        private bool _UpdateClass()
        {
            //call DataAccess Layer 

            return ClassesDataAccess.UpdateClass(this.ClassID,this.CoachID,this.className,this.Description,this.StartTime,this.EndTime
                ,this.Note,this.Maximum_Capacity,this.IsActive,this.StartDay,this.EndDay);
        }

        //Added a public `Save()` method to manage saving logic based on
        //the current mode, supporting both adding and updating classes.
        public bool Save()
        {
            switch (_Mode)
            {

                case enMode.AddNew:
                    if (_AddClass())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateClass();

            }

            return false;
        }


        public static DataTable GetAllClasses()
        {
            return ClassesDataAccess.GetAllClasses();
        }

        public static bool DeleteClass(int ClassID)
        {
            return ClassesDataAccess.DeleteClass(ClassID);
        }



    }
}
