using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
   static public class clsEmployeeShiftData
    {

        static public DataTable GetAllEmployeeShift()
        {
            DataTable dt = new DataTable();
            string query = "select ShiftID as 'Shift ID',ShiftType as 'Shift Type',StartTime as 'Start Time',EndTime as 'End Time' from EmployeesShift;";

            using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    }
}
