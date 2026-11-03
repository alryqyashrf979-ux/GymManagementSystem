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
                              U.Username as 'Refunded By',case RefundMethod when 1 then 'Cash' when 2 then Card else 'Unknown' end 
                              as 'Method' ,R.RefundedReason as 'Reason' from Refund R inner join Subscriptions S 
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

        static public int AddRefund(int SubscriptionID, double RefundAmount, byte RefundMethod, int CreatedByUserID, string RefundedReason)
        {
            string query = @" INSERT INTO [dbo].[Refund]
           ([SubscriptionID]
           ,[RefundAmount]
           ,[RefundDate]
           ,[RefundedByUserID]
           ,[RefundMethod]
           ,[RefundedReason])
     VALUES
           (@SubscriptionID,
           ,@RefundAmount,
           ,@RefundDate,
           ,@RefundedByUserID,
           ,@RefundMethod
           ,@RefundedReason,);
            SELECT SCOPE_IDENTITY();
";




            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                        command.Parameters.AddWithValue("@RefundAmount", RefundAmount);
                        command.Parameters.AddWithValue("@RefundDate", DateTime.Now);
                        command.Parameters.AddWithValue("@RefundedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@RefundedReason", RefundedReason);
                        command.Parameters.AddWithValue("@RefundMethod", RefundMethod);

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

        static public bool UpdateRefund(int SubscriptionID, double RefundAmount, byte RefundMethod, int CreatedByUserID, string RefundedReason)
        {
            string query = @"UPDATE [dbo].[Refund]
   SET [SubscriptionID] = SubscriptionID, 
      ,[RefundAmount] = RefundAmount,
      ,[RefundDate] = RefundDate,
      ,[RefundedByUserID] = RefundedByUserID,
      ,[RefundedReason] = RefundedReason,
      ,[RefundMethod] = RefundMethod,
 WHERE RefundID=@RefundID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                        command.Parameters.AddWithValue("@RefundAmount", RefundAmount);
                        command.Parameters.AddWithValue("@RefundDate", DateTime.Now);
                        command.Parameters.AddWithValue("@RefundedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@RefundedReason", RefundedReason);
                        command.Parameters.AddWithValue("@RefundMethod", RefundMethod);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        static public bool DeleteRefund(int RefundID)
        {
            string query = " Delete From Refund where RefundID=@RefundID; ";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RefundID", RefundID);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        static public bool Find(int RefundID, ref int SubscriptionID, ref double RefundAmount, ref byte RefundMethod, ref DateTime RefundDate, ref int CreatedByUserID)
        {
            string query = " select *from Refund where RefundID=@RefundID; ";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RefundID", RefundID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SubscriptionID = (int)reader["SubscriptionID"];
                                RefundAmount = Convert.ToDouble((reader)["RefundAmount"]);
                                RefundMethod =Convert.ToByte (reader["RefundMethod"]);
                                RefundDate = (DateTime)reader["PaymentDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
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
