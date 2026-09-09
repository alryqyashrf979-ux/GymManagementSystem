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
    public class clsClassesDataBusiness
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




        private clsClassesDataBusiness(int classID, string className, string description, TimeSpan startTime, TimeSpan endTime,
            string note, byte maximum_Capacity, bool isActive, string startDay, string endDay, int coachID)
        {

            this.ClassID = classID;
            this.className = className;
            this.Description = description;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Note = note;
            this.Maximum_Capacity = maximum_Capacity;
            this.IsActive = isActive;
            this.StartDay = startDay;
            this.EndDay = endDay;
            this.CoachID = coachID;

            _Mode = enMode.Update;
             
        }


        public clsClassesDataBusiness()
        {
            this.ClassID = -1;
            this.CoachID = -1;
            this.Note = "";
            this.StartDay = "";
            this.EndDay = "";
            this.EndTime = TimeSpan.Zero;
            this.StartTime= TimeSpan.Zero;
            this.IsActive = false;
            this.Description = "";
            this.Maximum_Capacity = 0;
            this.className = "";

            _Mode = enMode.AddNew;

        }




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

        public static clsClassesDataBusiness GetClassInfoByClassID(int ClassID)
        {
            int coachID = -1;
            byte maximumCapacity = 0;
            string note = string.Empty;
            string className = string.Empty;
            string Description = string.Empty;
            TimeSpan startTime=TimeSpan.Zero;
            TimeSpan endTime=TimeSpan.Zero;
            string startDay = string.Empty;
            string endDay = string.Empty;
            bool isActive = false;

            if(ClassesDataAccess.GetClassInfoByClassID(ClassID,ref  coachID,ref className,ref Description,ref startTime
                ,ref endTime,ref note,ref maximumCapacity,ref isActive,ref startDay,ref endDay))
            {

                return new clsClassesDataBusiness(ClassID,className,Description,startTime,
                    endTime,note,maximumCapacity,isActive,startDay,endDay,coachID);

            }
            else
            {
                return null;
            }


        }




    }
}
