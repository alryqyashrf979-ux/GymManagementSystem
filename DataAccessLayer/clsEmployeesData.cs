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

        static public bool DeleteEmployee(int EmployeeID)
        {
            string query = " Delete Employees where EmployeeID=@EmployeeID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                        return Convert.ToInt32(command.ExecuteNonQuery()) > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
