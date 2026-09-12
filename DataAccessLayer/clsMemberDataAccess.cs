using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static public  class clsMemberDataAccess
    {
        static public bool FindmemberByMemberID(int MemberID, ref int PersonID, ref DateTime LastSubscriptionDate, ref bool IsActive, ref int ContactPersonInfo)
        {
            string Query = "select * from Members where MemberID = @MemberID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, con))
            {
                cmd.Parameters.AddWithValue("@MemberID", MemberID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        PersonID = (int)reader["PersonID"];
                        LastSubscriptionDate = (DateTime)reader["LastSubscriptionDate"];
                        IsActive = (bool)reader["IsActive"];
                        ContactPersonInfo = (int)reader["ContactPersonInfo"];
                        return true;
                    }



                }
            }
            return false;
        }
    }
}
