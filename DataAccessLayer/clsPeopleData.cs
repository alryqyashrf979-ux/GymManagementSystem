using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
   static public class clsPeopleData
    {

        static public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "select *from People;";
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

        static public bool GetPersonInfoByPersonID(int PersonID, ref string FirstName, ref string SecondName,
   ref string LastName, ref string PhoneNumber, ref char Gendor, ref DateTime Birthdate, ref int CountryID,
   ref string Email, ref string NationalID, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT [ID] ,[FirstName] ,[SecondName],[LastName],[PhoneNumber],[Gendre]" +
                " ,[Birthdate],[CountryID],[Email],[NationalID],[Address],[ImagePath] " +
                "FROM[dbo].[People] where ID = @PersonID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("PersonID", PersonID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Birthdate = (DateTime)reader["Birthdate"];
                    Gendor = (char)reader["Gendre"];
                    CountryID = (int)reader["CountryID"];
                    Email = (string)reader["Email"];
                    NationalID = (string)reader["NationalID"];
                    Address = (string)reader["Address"];
                    if ((string)reader["ImagePath"] != "")
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

    }
}
