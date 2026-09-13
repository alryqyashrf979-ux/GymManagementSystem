using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    static public class clsEmployeeAttendenceData
    {

        static public DataTable GetAllEmployeeAttendenceData()
        {
            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "select AttendanceID as 'Attendance ID' ,EmployeeID as 'Employee ID'" +
                ",CheckInTime as 'Check in Time',CheckoutTime as 'Check out Time',Note," +
                "IsStillWorking as 'Is Still Working'  from EmployeesAttendance;";

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
            catch(Exception ex)
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
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (EffectedRows > 0);
        }

        static public bool UpdateEmployeeAttendanceData(int AttendanceID,int EmployeeID,DateTime CheckInTime,DateTime CheckoutTime,string Note,bool IsStillWorking)
        {
            int RowEffect = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = " UPDATE [dbo].[EmployeesAttendance] SET [EmployeeID] = @EmployeeID," +
                "[CheckInTime] = @CheckInTime,[CheckoutTime] = @CheckoutTime,[Note] = @Note," +
                "[IsStillWorking] = @IsStillWorking WHERE AttendanceID=@AttendanceID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("AttendanceID", AttendanceID);
            command.Parameters.AddWithValue("EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("CheckInTime", CheckInTime);
            command.Parameters.AddWithValue("CheckoutTime", CheckoutTime);
            command.Parameters.AddWithValue("Note", Note);
            command.Parameters.AddWithValue("IsStillWorking", IsStillWorking);

            try
            {
                connection.Open();
               RowEffect = command.ExecuteNonQuery(); 
                
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (RowEffect > 0);
        }

        static public int AddEmployeeAttendanceData(int EmployeeID,DateTime CheckInTime,DateTime CheckoutTime,string Note,bool IsStillWorking)
        {
            int AttendanceID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "INSERT INTO [dbo].[EmployeesAttendance] ([EmployeeID],[CheckInTime] ," +
                "[CheckoutTime],[Note],[IsStillWorking]) VALUES (@EmployeeID,@CheckInTime,@CheckoutTime," +
                "@Note,@IsStillWorking) ;" +
                "Select scope_Identity();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("CheckInTime", CheckInTime);
            command.Parameters.AddWithValue("CheckoutTime", CheckoutTime);

            if(Note=="")
            command.Parameters.AddWithValue("Note", DBNull.Value);
            else
            command.Parameters.AddWithValue("Note", Note);

            command.Parameters.AddWithValue("IsStillWorking", IsStillWorking);

            try
            {
                connection.Open();
                object Resault = command.ExecuteScalar();

                if(int.TryParse( Resault.ToString(),out int _AttendanceID))
                {
                    AttendanceID = _AttendanceID;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return AttendanceID;
        }
    }
}
