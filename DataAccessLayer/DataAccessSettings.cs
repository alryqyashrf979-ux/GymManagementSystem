using System;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccessSettings
    {

       public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    }
}
