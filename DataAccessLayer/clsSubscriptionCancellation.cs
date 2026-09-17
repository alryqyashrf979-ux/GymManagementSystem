using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayer
{
   static public class clsSubscriptionCancellation
    {
       static public DataTable GetAllSubscriptionCancellation()
        {
            DataTable dt = new DataTable();

            string query = " select SubscriptionCancellationID as 'Cancellation ID',SubscriptionID as 'Subscription ID',RefundAmount as 'Refund'," +
                "ElapsedDays as 'Elapsed Days',CancellationDate as 'Date',Users.Username as 'Username' from SubscriptionCancellations inner join Users" +
                " on Users.UserID=SubscriptionCancellations.CancelledByUSerID;";

            using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    }
}
