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

        static public bool UpdateCoach(int CoachID,int EmployeeID,string Speciality,string Note)
        {
            string query = " UPDATE [dbo].[Coaches] SET [EmployeeID] = @EmployeeID,[Speciality] = @Speciality,[Note] = @Note WHERE CoachID=@CoachID; ";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("CoachID", CoachID);
                        command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("Speciality", Speciality);

                        if (string.IsNullOrEmpty(Note))
                            command.Parameters.AddWithValue("Note", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("Note", Note);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        static public bool DeleteCoach(int CoachID)
        {
            string query = "Delete from Coaches where CoachID=@CoachID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CoachID", CoachID);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        static public bool FindByCoachID(int CoachID,ref int EmployeeID,ref string Speciality,ref string Note)
        {
            string query = "Select *from Coaches where CoachID=@CoachID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("CoachID", CoachID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                EmployeeID = (int)reader["EmployeeID"];
                                Speciality = (string)reader["Speciality"];
                                if (reader["Note"] == DBNull.Value)
                                    Note = string.Empty;
                                else
                                    Note = (string)reader["Note"];

                                return true;
                            }

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                
            }
            return false;
        }

        static public bool FindByEmployeeID(int CoachID, ref int EmployeeID, ref string Speciality, ref string Note)
        {
            string query = "Select *from Coaches where EmployeeID=@Employee;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("EmployeeID", EmployeeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CoachID = (int)reader["CoachID"];
                                Speciality = (string)reader["Speciality"];
                                if (reader["Note"] == DBNull.Value)
                                    Note = string.Empty;
                                else
                                    Note = (string)reader["Note"];

                                return true;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

    }
}
