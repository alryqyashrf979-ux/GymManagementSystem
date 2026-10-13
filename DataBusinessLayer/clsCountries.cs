using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class clsCountries
    {
        private int _CountryID;
        public int CountryID { get { return _CountryID; } }
        public string CountryName { set; get; }
        public enum enMode { AddMode = 0, UpdateMode = 2 }
        private enMode _Mode = enMode.AddMode;

        public clsCountries()
        {
            _CountryID = -1;
            CountryName = string.Empty;
            _Mode = enMode.AddMode;
        }
        private clsCountries(int CountryID, string CountryName)
        {
            _CountryID = CountryID;
            this.CountryName = CountryName;
            _Mode = enMode.UpdateMode;
        }

        static public clsCountries Find(int CountryID)
        {
            string CountryName = string.Empty;
            bool IsFound = clsCountriesDataAccess.FindByCountryID(CountryID, ref CountryName);

            if (IsFound)
                return new clsCountries(CountryID, CountryName);
            else
                return null;
        }

        static public DataTable GetAlllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries();

        }


    }
}
