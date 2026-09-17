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

        static public int AddPayment(int SubscriptionID,int PaymentAmount,int ActualAmount,int PaymentMethod,DateTime PaymentDate, int CreatedByUserID)
        {
            string query = " INSERT INTO [dbo].[Payments]" +
                " ([SubscriptionID],[PaymentAmount],[ActualAmount],[TotalRemaining],[PaymentMethod],[PaymentDate],[CreatedByUserID])" +
                " VALUES (@SubscriptionID,@PaymentAmount,@ActualAmount,@PaymentAmount-@ActualAmount,@PaymentMethod,@PaymentDate,@CreatedByUserID) ";

            try
            {
                using(SqlConnection connection =new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("SubscriptionID", SubscriptionID);
                        command.Parameters.AddWithValue("PaymentAmount", PaymentAmount);
                        command.Parameters.AddWithValue("ActualAmount", ActualAmount);
                        command.Parameters.AddWithValue("PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("CreatedByUserID", CreatedByUserID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return -1;
        }
    }
}
