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
            string Query = @"
         select M.MemberID,P.ID as PersonID, P.FirstName+' '+P.SecondName+' '+P.LastName as FullName,
         case when P.Gender = 0 then 'Male' else 'Female'  end as 'Gender',
         P.PhoneNumber,P.Email,C.CountryName,M.LastSubscriptionID,M.EmergencyContactInfoID,M.IsActive
         from Members M  join People P on M.PersonID=P.ID join Countries C on C.CountryID=P.CountryID
 ";
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
        static public bool DoesMemberExistByMemberID(int MemberID)
        {
            string Query = "select Found = 1 from Members where MemberID = @MemberID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                con.Open();
                command.Parameters.AddWithValue("@MemberID", MemberID);

                using (SqlDataReader Reader = command.ExecuteReader())
                    return (Reader.HasRows);
            }
        }
        static public bool DoesMemberExistByPersonID(int PersonID)
        {
            string Query = "select Found = 1 from Members where PersonID = @PersonID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                con.Open();
                command.Parameters.AddWithValue("@PersonID", PersonID);

                using (SqlDataReader Reader = command.ExecuteReader())
                    return (Reader.HasRows);
            }
        }
        static public bool Delete(int MemberID)
        {
            string Query = "Delete from Members Where MemberID =@MemberID ";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                con.Open();
                command.Parameters.AddWithValue("@MemberID", MemberID);
                return command.ExecuteNonQuery() > 0;
            }
           
        }

        static public bool Update(int MemberID, int PersonID, int LastSubscriptionID, bool IsActive, int ContactPersonInfoID,string InActivationReason)
        {
            string Query = " Update Members " +
                "set PersonID = @PersonID , " +
                "LastSubscriptionID = @LastSubscriptionID ," +
                "IsActive = @IsActive , " +
                "EmergencyContactInfoID = @ContactPersonInfoID ,InActivationReason=@InActivationReason " +
                "where MemberID = @MemberID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                con.Open();
                command.Parameters.AddWithValue("@PersonID", PersonID);

                if (LastSubscriptionID != -1)
                    command.Parameters.AddWithValue("@LastSubscriptionID", LastSubscriptionID);
                else
                    command.Parameters.AddWithValue("@LastSubscriptionID", DBNull.Value);

                if (InActivationReason != "")
                    command.Parameters.AddWithValue("@InActivationReason", InActivationReason);
                else
                    command.Parameters.AddWithValue("@InActivationReason", DBNull.Value);


                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@ContactPersonInfoID", ContactPersonInfoID);
                command.Parameters.AddWithValue("@MemberID", MemberID);

                return command.ExecuteNonQuery() > 0;

            }
            
        }

        static public int Add(int PersonID, int LastSubscriptionID, bool IsActive, int ContactPersonInfoID,string InActivationReason)
        {
            string Query = "Insert into Members " +
                "values (@PersonID , @LastSubscriptionID , @IsActive , @ContactPersonInfoID,@InActivationReason) ; select SCOPE_IDENTITY();";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(Query, con))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    if (LastSubscriptionID != -1)
                        command.Parameters.AddWithValue("@LastSubscriptionID", LastSubscriptionID);
                    else
                        command.Parameters.AddWithValue("@LastSubscriptionID", DBNull.Value);

                    if (InActivationReason != "")
                        command.Parameters.AddWithValue("@InActivationReason", InActivationReason);
                    else
                        command.Parameters.AddWithValue("@InActivationReason", DBNull.Value);


                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@ContactPersonInfoID", ContactPersonInfoID);
                    object Result = command.ExecuteScalar();
                    if (Result != null && int.TryParse(Result.ToString(), out int NewID))
                        return NewID;
                }

            }
          
            return -1;

        }

        static public bool FindMemberByPersonID(int PersonID, ref int MemberID, ref int LastSubscriptionID, ref bool IsActive, ref int ContactPersonInfoID, ref string InActivationReason)
        {
            string Query = "select * from Members where PersonID = @PersonID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {

                        if (reader["InActivationReason"] != DBNull.Value)
                            InActivationReason = (string)reader["InActivationReason"];
                        else
                            InActivationReason = "";


                        if (reader["LastSubscriptionID"] != DBNull.Value)
                            LastSubscriptionID = (int)reader["LastSubscriptionID"];
                        else
                            LastSubscriptionID = -1;

                        MemberID = (int)reader["MemberID"];
                        IsActive = (bool)reader["IsActive"];
                        ContactPersonInfoID = (int)reader["EmergencyContactInfoID"];
                        return true;
                    }
                }
            }
            return false;
        }
        static public bool FindMemberByNationalNu(string NationalNu, ref int PersonID,ref int MemberID, ref int LastSubscriptionID, ref bool IsActive, ref int ContactPersonInfoID, ref string InActivationReason)
        {
            string Query = @"select Members.* from Members inner join People  on Members.PersonID =People.ID 
                                where People.NationalID=@NationalNu";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@NationalNu", NationalNu);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {

                        if (reader["InActivationReason"] != DBNull.Value)
                            InActivationReason = (string)reader["InActivationReason"];
                        else
                            InActivationReason = "";


                        if (reader["LastSubscriptionID"] != DBNull.Value)
                            LastSubscriptionID = (int)reader["LastSubscriptionID"];
                        else
                            LastSubscriptionID = -1;

                        PersonID = (int)reader["PersonID"];
                        MemberID = (int)reader["MemberID"];
                        IsActive = (bool)reader["IsActive"];
                        ContactPersonInfoID = (int)reader["EmergencyContactInfoID"];
                        return true;
                    }
                }
            }
            return false;
        }

        static public bool FindMemberByMemberID(int MemberID, ref int PersonID, ref int LastSubscriptionID, ref bool IsActive, ref int ContactPersonInfoID,ref string InActivationReason)
        {
            string Query = "select * from Members where MemberID = @MemberID";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@MemberID", MemberID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {

                        if (reader["InActivationReason"] != DBNull.Value)
                            InActivationReason = (string)reader["InActivationReason"];
                        else
                            InActivationReason = "";



                        PersonID = (int)reader["PersonID"];

                        if (reader["LastSubscriptionID"] != DBNull.Value)
                            LastSubscriptionID = (int)reader["LastSubscriptionID"];
                        else
                            LastSubscriptionID = -1;

                        IsActive = (bool)reader["IsActive"];
                        ContactPersonInfoID = (int)reader["EmergencyContactInfoID"];
                        return true;
                    }
                }
            }
            return false;
        }

    }


}

