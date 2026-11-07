using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
     public class clsTitles
    {
        public int TitleID { get; private set; }
        public string TitleName { get; set; }
        public enum enMode { AddMode,UpdateMode }
        private enMode _Mode = enMode.AddMode;
        public clsTitles()
        {
            TitleID = -1;
            TitleName = string.Empty;
            _Mode = enMode.AddMode;
        }
        clsTitles(string TitleName)
        {
            this.TitleName = TitleName;
            _Mode = enMode.UpdateMode;
        }

        static public DataTable GetAllTitles()
        {
            return clsTitlesData.GetAllTitles();
        }

  static public bool DeleteJopTitle(int TitleID)
        {
            return clsTitlesData.DeleteJopTitle(TitleID);
        }

        private bool _AddNewJopTitle()
        {
            this.TitleID = clsTitlesData.AddTitle(this.TitleName);
            return (this.TitleID != -1);
        }

        private bool _UpdateJopTitle()
        {
           return clsTitlesData.UpdateTitle(this.TitleID, this.TitleName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddNewJopTitle())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.UpdateMode:
                    return _UpdateJopTitle();
            }
            return false;
        }

        static public clsTitles Find(int TitleID)
        {
            string TitleName = string.Empty;

            bool IsFound = clsTitlesData.Find(TitleID,ref TitleName);

            if (IsFound)
                return new clsTitles(TitleName);
            else
                return null;
        }
    }
}
