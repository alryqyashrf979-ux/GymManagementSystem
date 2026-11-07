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
      
        static public DataTable GetAllCoaches()
        {
            DataTable dt = new DataTable();
            string query = @"select CoachID as 'Coach ID' , Coaches.EmployeeID as 'Employee ID',
                  p.FirstName+' '+p.SecondName+' '+p.LastName as 'Coach Name',Coaches.Speciality
                  from Coaches join Employees on 
                  Coaches.EmployeeID=Employees.EmployeeID join People P on P.ID=Employees.PersonID 
                  ";

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
                " VALUES (@EmployeeID,@Speciality,@Note);select scope_Identity();";

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
       public static bool IsCoach(int EmployeeID)
        {

            string query = @" select  1 as 'Found' from Coaches where EmployeeID = @EmployeeID";

            try
            {
                
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand com = new SqlCommand(query, conn))
                    {


                        com.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                        SqlDataReader Read=com.ExecuteReader();

                        return Read.HasRows;


                    }


                }



            }
            catch(Exception ex)
            {
                return false;
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
