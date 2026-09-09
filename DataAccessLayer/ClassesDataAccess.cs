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
    public class ClassesDataAccess
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


            if (Description != ""&& Description!= null)
                Command.Parameters.AddWithValue("@Description", Description);
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);

            Command.Parameters.AddWithValue("@StartTime", StartTime);
            Command.Parameters.AddWithValue("@EndTime", EndTime);

            if (Note != ""&& Note!=null)
                Command.Parameters.AddWithValue("@Note", Note);
            else
                Command.Parameters.AddWithValue("@Note", DBNull.Value);

            Command.Parameters.AddWithValue("@Maximum_Capacity", Maximum_Capacity);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            if(EndDay != "" && EndDay != null)
                Command.Parameters.AddWithValue("@EndDay", EndDay);
            else
                Command.Parameters.AddWithValue("@EndDay", DBNull.Value);

            if (StartDay != null && StartDay != null)
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


            if (Description != "" && Description != null)
                Command.Parameters.AddWithValue("@Description", Description);
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);

            Command.Parameters.AddWithValue("@StartTime", StartTime);
            Command.Parameters.AddWithValue("@EndTime", EndTime);

            if (Note != "" && Note != null)
                Command.Parameters.AddWithValue("@Note", Note);
            else
                Command.Parameters.AddWithValue("@Note", DBNull.Value);

            Command.Parameters.AddWithValue("@Maximum_Capacity", Maximum_Capacity);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            if (EndDay != "" && EndDay != null)
                Command.Parameters.AddWithValue("@EndDay", EndDay);
            else
                Command.Parameters.AddWithValue("@EndDay", DBNull.Value);

            if (StartDay != null && StartDay != null)
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

            string query =
              @"select Classes.ClassID,Classes.className,Classes.CoachID,Classes.StartTime,Classes.EndTime,Classes.Maximum_Capacity,
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





    }
}
