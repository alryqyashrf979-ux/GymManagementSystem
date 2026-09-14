using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class clsEmployeeAttendance
    {
        static public DataTable GetAllEmployeeAttendenceData()
        {
            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "select AttendanceID as 'Attendance ID' , EmployeeID as 'Employee ID',IsCheckin as 'Is Checkin'," +
                "IsCheckout as 'Is Checkout',Note,Date from EmployeesAttendance;";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


    }
}
