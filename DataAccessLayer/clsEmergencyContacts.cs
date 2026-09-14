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

      





    }
}
