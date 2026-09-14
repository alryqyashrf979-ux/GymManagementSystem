using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsEmergencyContacts
    {



        public static int AddEmergencyContact(string Name, string Relationship, string PhoneNumber)
        {
            string query = "INSERT INTO EmergencyContacts (Name, Relationship, PhoneNumber) VALUES (@Name, @Relationship, @PhoneNumber);" +
                " SELECT SCOPE_IDENTITY();";
            try
            {

                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    conn.Open();


                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Relationship", Relationship);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);


                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int newId))
                    {
                        return newId;
                    }
                    else
                    {
                        return -1; // Indicate failure to retrieve new ID
                    }



                }
            }
            catch (Exception ex)
            {
                // Handle exception
                return -1;
            }
        }


        public static bool GetEmergencyContactByID(int ID, ref string Name, ref string Relationship, ref string PhoneNumber)
        {
            string query = "SELECT Name, Relationship, PhoneNumber FROM EmergencyContacts WHERE ID = @ID";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Name = reader["Name"].ToString();
                            Relationship = reader["Relationship"].ToString();
                            PhoneNumber = reader["PhoneNumber"].ToString();
                            return true; // Contact found
                        }
                        else
                        {
                            return false; // Contact not found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }
        }



        public static bool UpdateEmergencyContact(int ID, string Name, string Relationship, string PhoneNumber)
        {


            string query = "UPDATE EmergencyContacts SET Name = @Name, Relationship = @Relationship, PhoneNumber = @PhoneNumber WHERE ID = @ID";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Relationship", Relationship);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                    return cmd.ExecuteNonQuery() > 0; // Return true if at least one row was updated
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }


        }


        public static bool DeleteEmergencyContact(int ID)
        {


            string query = "DELETE FROM EmergencyContacts WHERE ID = @ID";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    return cmd.ExecuteNonQuery() > 0; // Return true if at least one row was deleted
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }


        }



        public static DataTable GetAllEmergencyContacts()
        {
            string query = "SELECT * FROM EmergencyContacts";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {

                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }

            return dt;
        }


    }
}
