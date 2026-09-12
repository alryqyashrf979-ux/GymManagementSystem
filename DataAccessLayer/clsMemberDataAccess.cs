using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
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
        static public bool FindmemberByPersonID(int PersonID, ref int MemberID, ref DateTime LastSubscriptionDate, ref bool IsActive, ref int ContactPersonInfo)
        {
            string Query = "select * from Members where PersonID = @PersonID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, con))
            {
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MemberID = (int)reader["MemberID"];
                        LastSubscriptionDate = (DateTime)reader["LastSubscriptionDate"];
                        IsActive = (bool)reader["IsActive"];
                        ContactPersonInfo = (int)reader["ContactPersonInfo"];
                        return true;
                    }
                }
            }
            return false;
        }

        static public int Add(int PersonID, DateTime LastSubscriptionID, bool IsActive, int ContactPersonInfoID)
        {
            string Query = "Insert into Members " +
                "values (@PersonID , @LastSubscriptionID , @IsActive , @ContactPersonInfoID) , select SCOPE_IDENTITY();";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(Query, con))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@LastSubscriptionID", LastSubscriptionID);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@ContactPersonInfoID", ContactPersonInfoID);
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int NewID))
                    return NewID;
            }
            return -1;

        }

        static public bool Update(int MemberID, int PersonID, DateTime LastSubscriptionID, bool IsActive, int ContactPersonInfoID)
        {
            string Query = " Update Members " +
                "set PersonID = @PersonID , " +
                "LastSubscriptionID = @LastSubscriptionID ," +
                "IsActive = @IsActive , " +
                "ContactPersonInfoID = @ContactPersonInfoID " +
                "where MemberID = @MemberID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@LastSubscriptionID", LastSubscriptionID);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@ContactPersonInfoID", ContactPersonInfoID);
                command.Parameters.AddWithValue("@MemberID", MemberID);

                return command.ExecuteNonQuery() > 0;

            }
            return false;
        }


}
}
