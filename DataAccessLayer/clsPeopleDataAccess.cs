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
            string query = "select ID ,nationalID as 'National ID', FirstName+' '+SecondName+' '+ LastName as 'Full Name' " +
                ", PhoneNumber as 'Phone Number' , \r\ncase when gender = 0 then 'Male' else 'Female'  end as 'Gendre' " +
                ", Birthdate as 'Birth date' , C.CountryName as 'Country ',\r\nEmail , Address" +
                " from people P inner join Countries C on P.COuntryID = C.CountryID\r\n";
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
ref string LastName, ref string PhoneNumber, ref char Gender, ref DateTime Birthdate, ref int CountryID,
ref string Email, ref string NationalID, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT  [FirstName] ,[SecondName],[LastName],[PhoneNumber],[Gender]" +
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
                    Gender = (char)reader["Gender"];
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
