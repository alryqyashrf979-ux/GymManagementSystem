using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static public class clsCountriesDataAccess
    {
        static public DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            string query = "select * from Countries ";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }

                }
                return dt;

            }
        }

        static public bool FindByCountryID(int CountryID, ref string CountryName)
        {
            string query = "select CountryName from Countries where CountryID=@CountryID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CountryName = (string)reader["CountryName"];
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}