using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   static public class clsPaymentData
    {
        static public DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();
            string query = "select PaymentID as 'Payment ID',SubscriptionID as 'Subscription ID',PaymentAmount as 'Payment Amount'," +
                "ActualAmount as 'Actual Amount',TotalRemaining as 'Total Remaining',case PaymentMethod when 1 then' Cash' when 2 then 'Card'" +
                " else 'Unknown' end as 'Payment Method' ,PaymentDate as 'Date',CreatedByUserID as 'Username' from Payments;";

            using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command=new SqlCommand(query, connection))
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
            return dt;
        }
    }
}
