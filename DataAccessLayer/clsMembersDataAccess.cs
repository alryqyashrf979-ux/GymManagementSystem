using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsMembersDataAccess
    {
        static public DataTable GetAllMembers()
        {
            DataTable dt = new DataTable();
            string Query = "select * from Members ";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
                return dt;

            }
        }
        static public bool DoesPersonExistByMemberID(int MemberID)
        {
            string Query = "select Found = 1 from Members where MemberID = @MemberID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                con.Open();
                command.Parameters.AddWithValue("@MemberID", MemberID);
                return command.ExecuteNonQuery() > 0;
            }
        }
        static public bool DoesPersonExistByPersonID(int PersonID)
        {
            string Query = "select Found = 1 from Members where PersonID = @PersonID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
