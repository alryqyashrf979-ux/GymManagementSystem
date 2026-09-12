using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsClassesData
    {

        public static int AddNewClass(int CoachID,string className,string Description,TimeSpan StartTime,TimeSpan EndTime,string Note,byte Maximum_Capacity,
            bool IsActive,string StartDay,string EndDay)
        {

            //this function will return the new person id if succeeded and -1 if not.

            int ClassID = -1;

            string query = @"INSERT INTO [dbo].[Classes]
           ([className]
           ,[Description]
           ,[StartTime]
           ,[EndTime]
           ,[Note]
           ,[Maximum_Capacity]
           ,[IsActive]
           ,[EndDay]
           ,[StartDay]
           ,[CoachID])
     VALUES
           (@className
           ,@Description
           ,@StartTime
           ,@EndTime
           ,@Note
           ,@Maximum_Capacity
           ,@IsActive
           ,@EndDay
           ,@StartDay
           ,@CoachID);

 SELECT SCOPE_IDENTITY();

";

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(query, connection);


            Command.Parameters.AddWithValue("@CoachID", CoachID);
            Command.Parameters.AddWithValue("@className", className);


            if (!string.IsNullOrEmpty(Description))
                Command.Parameters.AddWithValue("@Description", Description);
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);

            Command.Parameters.AddWithValue("@StartTime", StartTime);
            Command.Parameters.AddWithValue("@EndTime", EndTime);


            if (!string.IsNullOrEmpty(Note))

                Command.Parameters.AddWithValue("@Note", Note);
            else
                Command.Parameters.AddWithValue("@Note", DBNull.Value);

            Command.Parameters.AddWithValue("@Maximum_Capacity", Maximum_Capacity);
            Command.Parameters.AddWithValue("@IsActive", IsActive);


            if(!string.IsNullOrEmpty(EndDay))

                Command.Parameters.AddWithValue("@EndDay", EndDay);
            else
                Command.Parameters.AddWithValue("@EndDay", DBNull.Value);

 (!string.IsNullOrEmpty(StartDay))
                Command.Parameters.AddWithValue("@StartDay", StartDay);
            else
                Command.Parameters.AddWithValue("@StartDay", DBNull.Value);

            try
                {

                    connection.Open();

                    object Result = Command.ExecuteScalar();

                    if (Result != null && int.TryParse(Result.ToString(), out int NewClassID))
                    {

                        ClassID = NewClassID;

                    }

                }
                catch (Exception ex)
                {

                    ClassID = -1;

                }

                finally
                { connection.Close(); }


            return ClassID;

        }



        public static bool UpdateClass(int ClassID, int CoachID, string className, string Description, TimeSpan StartTime, TimeSpan EndTime, string Note, byte Maximum_Capacity,
       bool IsActive, string StartDay, string EndDay)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[Classes]
        SET [className] = @className
      ,[Description] = @Description
      ,[StartTime] = @StartTime
      ,[EndTime] = @EndTime
      ,[Note] = @Note
      ,[Maximum_Capacity] = @Maximum_Capacity
      ,[IsActive] = @IsActive
      ,[EndDay] = @EndDay
      ,[StartDay] = @StartDay,
       [CoachID]= @CoachID
          WHERE ClassID =@ClassID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@CoachID", CoachID);


            Command.Parameters.AddWithValue("@ClassID", ClassID);
            Command.Parameters.AddWithValue("@className", className);

            //      adding !string.IsNullOrEmpty(Description) to simlpifygit  code

            if (!string.IsNullOrEmpty(Description))
                Command.Parameters.AddWithValue("@Description", Description);
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);

            Command.Parameters.AddWithValue("@StartTime", StartTime);
            Command.Parameters.AddWithValue("@EndTime", EndTime);


            if (!string.IsNullOrEmpty(Note))

                Command.Parameters.AddWithValue("@Note", Note);
            else
                Command.Parameters.AddWithValue("@Note", DBNull.Value);

            Command.Parameters.AddWithValue("@Maximum_Capacity", Maximum_Capacity);
            Command.Parameters.AddWithValue("@IsActive", IsActive);


            if (!string.IsNullOrEmpty(EndDay))
                Command.Parameters.AddWithValue("@EndDay", EndDay);
            else
                Command.Parameters.AddWithValue("@EndDay", DBNull.Value);
            // StartDay != "" not null 

            if (!string.IsNullOrEmpty(StartDay))

                Command.Parameters.AddWithValue("@StartDay", StartDay);
            else
                Command.Parameters.AddWithValue("@StartDay", DBNull.Value);


            try
            {
                connection.Open();
                rowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllClasses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            /*
                changeed @"select Classes.ClassID as 'Class ID' ,Classes.className,Classes.CoachID,Classes.StartTime,Classes.EndTime,Classes.Maximum_Capacity,
Classes.IsActive from Classes ;

            to 

               @"select Classes.ClassID as 'Class ID' ,Classes.className as 'Class Name ',Classes.CoachID as 'Coach ID',Classes.StartTime as'Start Time
',Classes.EndTime as 'End Time',Classes.Maximum_Capacity,
Classes.IsActive from Classes ;
";
            */
            string query =
              @"select Classes.ClassID as 'Class ID' ,Classes.className as 'Class Name ',Classes.CoachID as 'Coach ID',Classes.StartTime as'Start Time
',Classes.EndTime as 'End Time',Classes.Maximum_Capacity,
Classes.IsActive from Classes ;
";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {

                // Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return dt;

        }


        public static bool DeleteClass(int ClassID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Delete Classes 
                                where ClassID = @ClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassID", ClassID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }



        public static bool GetClassInfoByClassID(int ClassID, ref int CoachID,ref string className, ref string Description,ref TimeSpan StartTime,ref TimeSpan EndTime, ref string Note,ref byte Maximum_Capacity,
       ref bool IsActive,ref string StartDay, ref string EndDay)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Classes WHERE ClassID = @ClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassID", ClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    if (reader["Note"] != DBNull.Value)
                    {
                        Note = (string)reader["Note"];
                    }
                    else
                    {
                        Note = "";
                    }

                    if (reader["StartDay"] != DBNull.Value)
                    {
                        StartDay = (string)reader["StartDay"];
                    }
                    else
                    {
                        StartDay = "";
                    }

                    if (reader["EndDay"] != DBNull.Value)
                    {
                        EndDay = (string)reader["EndDay"];
                    }
                    else
                    {
                        EndDay = "";
                    }

                    if (reader["Description"] != DBNull.Value)
                    {
                        Description = (string)reader["Description"];
                    }
                    else
                    {
                        Description = "";
                    }

                    Maximum_Capacity = (byte)reader["Maximum_Capacity"];
                    IsActive = (bool)reader["IsActive"];
                    CoachID = (int)reader["CoachID"];
                    StartTime = (TimeSpan)reader["StartTime"];
                    EndTime = (TimeSpan)reader["EndTime"];

                    

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


    }
}
