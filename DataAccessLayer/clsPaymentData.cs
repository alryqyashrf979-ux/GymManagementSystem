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

        static public int AddPayment(int SubscriptionID, double PaymentAmount, double ActualAmount,int PaymentMethod, int CreatedByUserID)
        {
            string query = " INSERT INTO [dbo].[Payments]" +
                " ([SubscriptionID],[PaymentAmount],[ActualAmount],[TotalRemaining],[PaymentMethod],[PaymentDate],[CreatedByUserID])" +
                " VALUES (@SubscriptionID,@PaymentAmount,@ActualAmount,@PaymentAmount-@ActualAmount,@PaymentMethod,@PaymentDate,@CreatedByUserID);" +
                "select scope_Idintity(); ";

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
                        command.Parameters.AddWithValue("PaymentDate", DateTime.Now);
                        command.Parameters.AddWithValue("CreatedByUserID", CreatedByUserID);

                        object Resault = command.ExecuteScalar();
                        if (int.TryParse(Resault.ToString(), out int Value))
                            return Value;
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return -1;
        }
    
        static public bool UpdatePayment(int PaymentID,int SubscriptionID, double PaymentAmount, double ActualAmount, int PaymentMethod, int CreatedByUserID)
        {
            string query = "UPDATE [dbo].[Payments] SET " +
                "[SubscriptionID] = @SubscriptionID," +
                "[PaymentAmount] = @PaymentAmount," +
                "[ActualAmount] = @ActualAmount," +
                "[TotalRemaining] = @PaymentAmount-@ActualAmount ," +
                "[PaymentMethod] = @PaymentMethod," +
                "[PaymentDate] = @PaymentDate," +
                "[CreatedByUserID] = @CreatedByUserID" +
                " WHERE PaymentID=@PaymentID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PaymentID", PaymentID);
                        command.Parameters.AddWithValue("SubscriptionID", SubscriptionID);
                        command.Parameters.AddWithValue("PaymentAmount", PaymentAmount);
                        command.Parameters.AddWithValue("ActualAmount", ActualAmount);
                        command.Parameters.AddWithValue("PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("PaymentDate", DateTime.Now);
                        command.Parameters.AddWithValue("CreatedByUserID", CreatedByUserID);

                        return command.ExecuteNonQuery()>0;
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return false;
        }

        static public bool DeletePayment(int PaymentID)
        {
            string query = " Delete From Payments where PaymentID=@PaymentID; ";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PaymentID", PaymentID);

                        return command.ExecuteNonQuery()>0;
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return false;
        }

        static public bool Find(int PaymentID,ref int SubscriptionID,ref double PaymentAmount,ref double ActualAmount,ref double TotalRemaining, ref int PaymentMethod,ref DateTime PaymentDate,ref int CreatedByUserID)
        {
            string query = " select *from Payments where PaymentID=@PaymentID; ";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PaymentID", PaymentID);

                       using(SqlDataReader reader = command.ExecuteReader())
                        {
                            SubscriptionID = (int)reader["SubscriptionID"];
                            PaymentAmount = (double)reader["PaymentAmount"];
                            ActualAmount = (double)reader["ActualAmount"];
                            TotalRemaining = (double)reader["TotalRemaining"];
                            PaymentMethod = (int)reader["PaymentMethod"];
                            PaymentDate = (DateTime)reader["PaymentDate"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];

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
