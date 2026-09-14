using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        static public bool DeleteEmployeeAttendanceData(int AttendanceID)
        {
            int EffectedRows = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Delete EmployeesAttendance where AttendanceID=@AttendanceID; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AttendanceID", AttendanceID);

            try
            {
                connection.Open();
                EffectedRows = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (EffectedRows > 0);
        }

    }
}
