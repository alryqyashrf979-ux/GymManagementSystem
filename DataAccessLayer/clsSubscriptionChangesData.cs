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
    }
}
