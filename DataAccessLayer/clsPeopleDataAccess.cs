using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsPeopleDataAccess
    {

        static public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            // in this way it is formatted and ready to present .
            string query = @"select ID ,nationalID as 'National ID', FirstName+' '+SecondName+' '+ LastName as 'Full Name'
                , PhoneNumber as 'Phone Number' ,case when p.Gendre = 0 then 'Male' else 'Female'  end as 'Gendre' 
                , Birthdate as 'Birth date' , C.CountryName as 'Country ',Email , Address
                 from people P inner join Countries C on P.CountryID = C.CountryID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        static public bool GetPersonInfo(int PersonID, ref string FirstName, ref string SecondName,
ref string LastName, ref string PhoneNumber, ref char Gender, ref DateTime Birthdate, ref int CountryID,
ref string Email, ref string NationalID, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT  [FirstName] ,[SecondName],[LastName],[PhoneNumber],[Gender]" +
                " ,[Birthdate],[CountryID],[Email],[NationalID],[Address],[ImagePath] " +
                "FROM[dbo].[People] where ID = @PersonID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Birthdate = (DateTime)reader["Birthdate"];
                    Gender = (char)reader["Gender"];
                    CountryID = (int)reader["CountryID"];
                    Email = (string)reader["Email"];
                    NationalID = (string)reader["NationalID"];
                    Address = (string)reader["Address"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";
                }

            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        // ploymorphism is used .
        static public bool GetPersonInfo(string NationalID, ref int PersonID, ref string FirstName, ref string SecondName,
ref string LastName, ref string PhoneNumber, ref char Gender, ref DateTime Birthdate, ref int CountryID,
ref string Email, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT [ID] ,[FirstName] ,[SecondName],[LastName],[PhoneNumber],[Gender]" +
                " ,[Birthdate],[CountryID],[Email],[Address],[ImagePath] " +
                "FROM[dbo].[People] where NationalID = @NationalID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalID", NationalID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Birthdate = (DateTime)reader["Birthdate"];
                    Gender = (char)reader["Gender"];
                    CountryID = (int)reader["CountryID"];
                    Email = (string)reader["Email"];
                    PersonID = (int)reader["ID"];
                    Address = (string)reader["Address"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";
                }

            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        static public bool AddNewPerson(string FirstName, string SecondName, string LastName,
        string PhoneNumber, char Gender, DateTime Birthdate, int CountryID, string Email,
        string NationalID, string Address, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "  INSERT INTO [dbo].[People] ([FirstName],[SecondName],[LastName]," +
                " [PhoneNumber],[Gender],[Birthdate],[CountryID],[Email],[NationalID],[Address]," +
                "[ImagePath]) VALUES (@FirstName,@SecondName,@LastName,@PhoneNumber,@Gender," +
                "@Birthdate,@CountryID,@Email,@NationalID,@Address,@ImagePath); " +
                "select scope_Identity();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Birthdate", Birthdate);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalID", NationalID);
            command.Parameters.AddWithValue("@Address", Address);

            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("ImagePath", DBNull.Value);

            try
            {
                connection.Open();
                object Resault = command.ExecuteScalar();
                if (int.TryParse(Resault.ToString(), out int _PersonID))
                {
                    PersonID = _PersonID;
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return (PersonID != -1);
        }
        static public bool UpdatePersonInfo(int PersonID, string FirstName, string SecondName, string LastName,
           string PhoneNumber, char Gender, DateTime Birthdate, int CountryID, string Email,
           string NationalID, string Address, string ImagePath)
        {
            int rowEffect = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = " UPDATE [dbo].[People] SET" +
                " [FirstName] = @FirstName," +
                "[SecondName] = @SecondName," +
                "[LastName] = @LastName," +
                "[PhoneNumber] = @PhoneNumber," +
                "[Gender] = @Gender," +
                "[Birthdate] = @Birthdate," +
                "[CountryID] = @CountryID," +
                "[Email] = @Email," +
                "[NationalID] = @NationalID," +
                "[Address] = @Address," +
                "[ImagePath] = @ImagePath " +
                "WHERE ID=@PersonID; ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Birthdate", Birthdate);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalID", NationalID);
            command.Parameters.AddWithValue("@Address", Address);

            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("ImagePath", DBNull.Value);


            try
            {
                connection.Open();
                rowEffect = command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowEffect > 0);
        }


        static public bool DeletePerson(int PersonID)
        {
            int rowEffect = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM [dbo].[People] WHERE ID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("PersonID", PersonID);

            try
            {
                connection.Open();
                rowEffect = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowEffect > 0);
        }
        static public bool DoesPersonExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "select Found=1 from People where ID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        static public bool DoesPersonExist(string NationalID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "select Found=1 from People where NationalID=@National;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("NationalID", NationalID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

    }
}
