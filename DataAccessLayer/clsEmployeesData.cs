using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   static public class clsEmployeesData
    {
        static public DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();
            string query = "Select *from Employees;";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString)) 
            using(SqlCommand command=new SqlCommand(query, connection))
            {
                connection.Open();
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
                return dt;
            }

        }
    }
}
