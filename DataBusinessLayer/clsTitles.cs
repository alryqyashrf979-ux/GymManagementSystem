using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataBusinessLayer
{
    static public class clsTitles
    {
        static public DataTable GetAllTitles()
        {
            return clsTitlesData.GetAllTitles();
        }
    }
}
