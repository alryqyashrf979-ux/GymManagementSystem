using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   static public class clsCoachData
    {
      
        static public DataTable GetAllCoach()
        {
            DataTable dt = new DataTable();
            string query = "select CoachID as 'Coach ID' , EmployeeID as 'Employee ID',Speciality,Note from Coaches;";

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

        static public int AddCoach(int EmployeeID,string Speciality,string Note)
        {
            string query = "INSERT INTO [dbo].[Coaches] ([EmployeeID],[Speciality],[Note])" +
                " VALUES (@EmployeeID,@Speciality,@Note);select scope_Idintity();";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("Speciality", Speciality);

                        if(string.IsNullOrEmpty(Note))
                        command.Parameters.AddWithValue("Note", DBNull.Value);
                        else
                        command.Parameters.AddWithValue("Note", Note);

                        object Resault = command.ExecuteScalar();
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
    }
}
