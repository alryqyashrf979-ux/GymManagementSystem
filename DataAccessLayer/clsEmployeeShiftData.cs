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

        static public int AddEmployeeShift(string ShiftType,DateTime StartTime,DateTime EndTime)
        {
            string query = "INSERT INTO [dbo].[EmployeesShift] ([ShiftType],[StartTime],[EndTime]) " +
                "VALUES (@ShiftType,@StartTime,@EndTime);select scope_idintity();";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ShiftType", ShiftType);
                        command.Parameters.AddWithValue("@StartTime", StartTime);
                        command.Parameters.AddWithValue("@EndTime", EndTime);

                        object Resault = command.ExecuteNonQuery();

                        if (int.TryParse(Resault.ToString(), out int Value))
                            return Value;
                        else
                            return -1;
                    }
                }
            }
            catch
            {
                return -1;
            }
        }

        static public bool UpdateEmployeeShift(int ShiftID,string ShiftType,DateTime StartTime,DateTime EndTime)
        {
            string query = "UPDATE [dbo].[EmployeesShift] SET " +
                "[ShiftType] = @ShiftType," +
                "[StartTime] =@StartTime ," +
                "[EndTime] = @EndTime" +
                " WHERE ShiftID=@ShiftID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ShiftID", ShiftID);
                        command.Parameters.AddWithValue("ShiftType", ShiftType);
                        command.Parameters.AddWithValue("StartTime", StartTime);
                        command.Parameters.AddWithValue("EndTime", EndTime);

                        return command.ExecuteNonQuery()>0;
                    }
                }
            }
            catch
            {

            }
            return -1;
        }
    }
}
