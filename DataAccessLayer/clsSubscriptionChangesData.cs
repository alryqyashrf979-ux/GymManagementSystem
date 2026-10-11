using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    static public class clsSubscriptionChangesData
    {
     
        static public DataTable GetAllSubscriptionChanges()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT 
    SC.SubscriptionChangeID AS 'Change ID',
    P_New.Name AS 'New Subscription',
    P_Old.Name AS 'Previous Subscription',
    U.Username
FROM SubscriptionChanges SC
INNER JOIN Subscriptions S_New ON SC.NewSubscriptionID = S_New.SubscriptionID
INNER JOIN SubscriptionPlans P_New ON P_New.PlanID = S_New.PlanID
INNER JOIN Subscriptions S_Old ON SC.CancelledSubscriptionID = S_Old.SubscriptionID
INNER JOIN SubscriptionPlans P_Old ON P_Old.PlanID = S_Old.PlanID
INNER JOIN Users U ON U.UserID = SC.ChangedByUserID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(DataAccessSettings.ConnectionString))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return dt;
        }

        static public int AddSubscriptionChange(int NewSubscriptionID,int CancelledSubscriptionID,int ChangedByUserID,DateTime ChangeDateTime)
        {
            string query = " INSERT INTO [dbo].[SubscriptionChanges]([NewSubscriptionID],[CancelledSubscriptionID],[ChangedByUserID],[ChangeDateTime]) " +
                "VALUES (@NewSubscriptionID,@CancelledSubscriptionID,@ChangedByUserID,@ChangeDateTime);Select scope_Identity(); ";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewSubscriptionID", NewSubscriptionID);
                        command.Parameters.AddWithValue("@CancelledSubscriptionID", CancelledSubscriptionID);
                        command.Parameters.AddWithValue("@ChangedByUserID", ChangedByUserID);
                        command.Parameters.AddWithValue("@ChangeDateTime", ChangeDateTime);

                        object Resault= command.ExecuteScalar();

                        if (Resault!=null&& int.TryParse(Resault.ToString(), out int Value))
                            return Value;
                        else
                            return -1;
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return -1;
        }
    
        static public bool UpdateSubscriptionChange(int SubscriptionChangeID, int NewSubscriptionID, int CancelledSubscriptionID, int ChangedByUserID, DateTime ChangeDateTime)
        {
            string query = " UPDATE [dbo].[SubscriptionChanges] SET" +
                            " [NewSubscriptionID] = @NewSubscriptionID," +
                            "[CancelledSubscriptionID] = @CancelledSubscriptionID," +
                            "[ChangedByUserID] = @ChangedByUserID ," +
                            "[ChangeDateTime] = @ChangeDateTime" +
                            " WHERE SubscriptionChangeID=@SubscriptionChangeID; ";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubscriptionChangeID", SubscriptionChangeID);
                        command.Parameters.AddWithValue("@NewSubscriptionID", NewSubscriptionID);
                        command.Parameters.AddWithValue("@CancelledSubscriptionID", CancelledSubscriptionID);
                        command.Parameters.AddWithValue("@ChangedByUserID", ChangedByUserID);
                        command.Parameters.AddWithValue("@ChangeDateTime", ChangeDateTime);

                        return command.ExecuteNonQuery() > 0;

                    }
                }
            }
            catch(Exception ex)
            {

            }
            return false;
        }
    
        static public bool DeleteSubscriptionChanges(int SubscriptionChangeID)
        {
            string query = "Delete From [SubscriptionChanges] where SubscriptionChangeID=@SubscriptionChangeID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubscriptionChangeID", SubscriptionChangeID);

                        return command.ExecuteNonQuery() > 0;

                    }
                }
            }
            catch(Exception ex)
            {

            }
            return false;
        }

        static public bool Find(int SubscriptionChangeID,ref int NewSubscriptionID,ref int CancelledSubscriptionID,ref int ChangedByUserID,ref DateTime ChangeDateTime)
        {
            string query = " select *from [SubscriptionChanges] where SubscriptionChangeID=@SubscriptionChangeID; ";

            try
            {
                using (SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("SubscriptionChangeID", SubscriptionChangeID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            NewSubscriptionID = (int)reader["NewSubscriptionID"];
                            CancelledSubscriptionID = (int)reader["CancelledSubscriptionID"];
                            ChangedByUserID = (int)reader["ChangedByUserID"];
                            ChangeDateTime = (DateTime)reader["ChangeDateTime"];

                            return true;

                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return false;
        }
    }
}
