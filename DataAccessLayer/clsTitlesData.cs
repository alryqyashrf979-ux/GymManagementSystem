using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static public class clsTitlesData
    {
        static public DataTable GetAllTitles()
        {
            DataTable dt = new DataTable();
            string query = "select * from JobTitles;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            return dt;
        }
        static public int AddTitle(string TitleName)
        {
            string query = @"INSERT INTO [dbo].[JopTitles]
           ([TitleName])
     VALUES
           (@TitleName)";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("TitleName", TitleName);


                        object Resault = command.ExecuteScalar();
                        if (int.TryParse(Resault.ToString(), out int Value))
                            return Value;

                    }
                }
            }
            catch
            {

            }
            return -1;
        }

        static public bool UpdateTitle(int TitleID,string TitleName)
        {
            string query = @"UPDATE [dbo].[JobTitles]
   SET [TitleName] = @TitleName
 WHERE TitleID=@TitleID;
";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("TitleID", TitleID);
                        command.Parameters.AddWithValue("TitleName", TitleName);


                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        static public bool DeleteJopTitle(int TitleID)
        {
            string query = "Delete from JobTitles where TitleID=@TitleID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TitleID", TitleID);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        static public bool Find(int TItleID, ref string TitleName)
        {
            string query = "Select *from JobTitles where TitleID=@TitleID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("TitleID", TItleID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TitleName = (string)reader["TitleName"];
                         
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
