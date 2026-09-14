using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsUsersData
    {




        public static int AddNewUser(int PersonID, string UserName,
             string Password,sbyte Permission, bool IsActive)
        {

            string query = @"INSERT INTO Users (PersonID,UserName,Password,IsActive,Permission)
                             VALUES (@PersonID, @UserName,@Password,@IsActive,@Permission);
                             SELECT SCOPE_IDENTITY();";


            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {


                    conn.Open();

                    command.Parameters.AddWithValue("@Permission", Permission);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);


                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        return insertedID;
                    }
                    else
                        return -1;

                }


            }
            catch (Exception ex)
            {

                return -1;

            }

        }



        public static bool UpdateUser(int UserID,int PersonID, string UserName,
             string Password, sbyte Permission, bool IsActive)
        {

            string query = @"UPDATE Users SET PersonID=@PersonID, UserName=@UserName, Password=@Password, IsActive=@IsActive, Permission=@Permission
                             WHERE UserID=@UserID;";

            try
            {

                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query,conn))
                {

                    conn.Open();

                    command.Parameters.AddWithValue("@Permission", Permission);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@UserID", UserID);


                    return command.ExecuteNonQuery() > 0;   

                }

            }
            catch(Exception ex)
            {
                return false;
            }


        }






        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();

            string query = @"

                        SELECT  Users.UserID as 'User ID', Users.PersonID as 'Person ID',
                            FullName = People.FirstName + ' ' + People.SecondName+' ' + People.LastName,
                             Users.UserName as 'User Name', Users.IsActive
                             FROM  Users INNER JOIN
                                    People ON Users.PersonID = People.ID
";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader Reader =command.ExecuteReader())
                    {

                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                            return dt;
                        }
                        else
                            return null;
                    }

                }
            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return null;
            }
           

        }


















    }
}
