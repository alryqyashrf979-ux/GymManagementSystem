using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class clsRefundData
    {
        static public DataTable GetAllRefunds()
        {
            DataTable dt = new DataTable();
            string query = @"
                              select R.RefundID as 'Refund ID',P.FirstName+' '+P.SecondName+' '+isnull(P.LastName,' ') as 'Member Name',
                              R.SubscriptionID as 'Subscription ID',R.RefundAmount as 'Amount',R.RefundDate as 'Date',
                              U.Username as 'Refunded By',R.RefundedReason as 'Reason' from Refund R inner join Subscriptions S 
                             on S.SubscriptionID=R.SubscriptionID inner join Members M on M.MemberID=S.MemberID inner join People P 
                              on P.ID=M.PersonID inner join Users U on U.UserID=R.RefundedByUserID ;
                          ";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
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

        static public int AddPayment(int SubscriptionID, double PaymentAmount, double ActualAmount, double TotalRemaining, int PaymentMethod, int CreatedByUserID, byte Status)
        {
            string query = " INSERT INTO [dbo].[Payments]" +
                " ([SubscriptionID],[PaymentAmount],[ActualAmount],[TotalRemaining],[PaymentMethod],[PaymentDate],[CreatedByUserID],[Status])" +
                " VALUES (@SubscriptionID,@PaymentAmount,@ActualAmount,@TotalRemaining,@PaymentMethod,@PaymentDate,@CreatedByUserID,@Status);" +
                " SELECT SCOPE_IDENTITY(); ";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                        command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        command.Parameters.AddWithValue("@ActualAmount", ActualAmount);
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);
                        command.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        object Resault = command.ExecuteScalar();
                        if (Resault != null && int.TryParse(Resault.ToString(), out int Value))
                            return Value;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return -1;
        }

        static public bool UpdatePayment(int PaymentID, int SubscriptionID, double PaymentAmount, double ActualAmount, int PaymentMethod, int CreatedByUserID)
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
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                        command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        command.Parameters.AddWithValue("@ActualAmount", ActualAmount);
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        static public bool DeletePayment(int PaymentID)
        {
            string query = " Delete From Payments where PaymentID=@PaymentID; ";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        static public bool Find(int PaymentID, ref int SubscriptionID, ref double PaymentAmount, ref double ActualAmount, ref double TotalRemaining, ref int PaymentMethod, ref DateTime PaymentDate, ref int CreatedByUserID, ref byte Status)
        {
            string query = " select *from Payments where PaymentID=@PaymentID; ";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PaymentID", PaymentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SubscriptionID = (int)reader["SubscriptionID"];
                                PaymentAmount = Convert.ToDouble((reader)["PaymentAmount"]);
                                ActualAmount = Convert.ToDouble((reader)["ActualAmount"]);
                                TotalRemaining = Convert.ToDouble((reader)["TotalRemaining"]);
                                PaymentMethod = (int)reader["PaymentMethod"];
                                PaymentDate = (DateTime)reader["PaymentDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                Status = Convert.ToByte(reader["Status"]);
                                return true;
                            }



                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

    }
}
