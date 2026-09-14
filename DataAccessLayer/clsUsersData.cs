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


        public static bool Delete(int UserID)
        {
            string query = @"DELETE FROM Users WHERE UserID=@UserID;";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@UserID", UserID);
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }
        }



        public static bool IsUserExist(int UserID)
        {

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

           try
            {

                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    conn.Open();
                    cmd.Parameters.AddWithValue("@UserID", UserID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                       return reader.HasRows;
                    }

                }

            }
            catch(Exception ex)
            {
                return false;
            }


        }


        public static bool IsUserExist(string UserName)
        {

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";


            try
            {

                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    conn.Open();
                    cmd.Parameters.AddWithValue("@UserName", UserName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }

                }

            }
            catch (Exception ex)
            {
                return false;
            }


        }



        public static bool IsUserExistByPersonID(int PersonID)
        {

            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

            try
            {

               using(SqlConnection conn=new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }

            }
            catch(Exception e)
            {
                return false;
            }



        }


        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,
           ref  string Password,ref  sbyte Permission,ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permission = (sbyte)reader["Permission"];


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
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool GetUserInfoByPersonID(ref int UserID, int PersonID, ref string UserName,
           ref string Password, ref sbyte Permission, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permission = (sbyte)reader["Permission"];


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
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password,
            ref int UserID, ref int PersonID, ref bool IsActive, ref sbyte Permission)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Username = @Username and Password=@Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permission = (sbyte)reader["Permission"];



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
                //Console.WriteLine("Error: " + ex.Message);

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
