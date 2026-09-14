using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    static public class clsCountries
    {
        static public DataTable GetAlllCountries()
        {
           return clsCountriesDataAccess.GetAllCountries();

        }
    }
}
