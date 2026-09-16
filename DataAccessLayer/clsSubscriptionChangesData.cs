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

            string query = " select SubscriptionChangeID as 'Subscription Change ID',P.Name as 'New Subscription' ," +
                "(select P.Name  from SubscriptionChanges SC2 inner join Subscription S on SC2.CancelledSubscriptionID=S.SubscriptionID" +
                " inner join SubscriptionPlans P on P.PlanID=S.PlanID where SC2.SubscriptionChangeID=SC.SubscriptionChangeID) as 'Perviouse Subscription'," +
                "U.Username from SubscriptionChanges SC inner join Subscription S on SC.NewSubscriptionID=S.SubscriptionID " +
                " inner join SubscriptionPlans P on P.PlanID=S.PlanID inner join Users U on U.UserID=SC.ChangedByUserID; ";

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
                "VALUES (@NewSubscriptionID,@CancelledSubscriptionID,@ChangedByUserID,@ChangeDateTime);Select scope_Idintity(); ";

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

                        if (int.TryParse(Resault.ToString(), out int Value))
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
    
    }
}
