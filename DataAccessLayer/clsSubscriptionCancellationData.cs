using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayer
{
   static public class clsSubscriptionCancellationData
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

        static public int AddSubscriptionCancellation(int SubscriptionID,string CancellationReason,double RefundAmount,byte ElapsedDays,
            DateTime CancellationDate,int CancelledByUSerID)
        {
            string query = " INSERT INTO [dbo].[SubscriptionCancellations]([SubscriptionID] ,[CancellationReason],[RefundAmount]," +
                "[ElapsedDays] ,[CancellationDate] ,[CancelledByUSerID]) VALUES(@SubscriptionID,@CancellationReason,@RefundAmount," +
                "@ElapsedDays,@CancellationDate,@CancelledByUSerID);select SCOPE_IDENTITY(); ";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);

                        if(string.IsNullOrEmpty(CancellationReason))
                        command.Parameters.AddWithValue("@CancellationReason", DBNull.Value);
                        else
                        command.Parameters.AddWithValue("@CancellationReason", CancellationReason);

                        command.Parameters.AddWithValue("@RefundAmount", RefundAmount);
                        command.Parameters.AddWithValue("@ElapsedDays", ElapsedDays);
                        command.Parameters.AddWithValue("@CancellationDate", CancellationDate);
                        command.Parameters.AddWithValue("@CancelledByUSerID", CancelledByUSerID);

                        object Resault = command.ExecuteScalar();
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

        static public bool UpdateSubscriptionCancellation(int SubscriptionCancellationID,int SubscriptionID, string CancellationReason, double RefundAmount, byte ElapsedDays,
            DateTime CancellationDate, int CancelledByUSerID)
        {
            string query = "UPDATE [dbo].[SubscriptionCancellations] SET " +
                "[SubscriptionID] = @SubscriptionID ," +
                "[CancellationReason] = @CancellationReason," +
                "[RefundAmount] = @RefundAmount ," +
                "[ElapsedDays] = @ElapsedDays ," +
                "[CancellationDate] = @CancellationDate ," +
                "[CancelledByUSerID] = @CancelledByUSerID" +
                " Where SubscriptionCancellationID=@SubscriptionCancellationID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubscriptionCancellationID", SubscriptionCancellationID);
                        command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);

                        if (string.IsNullOrEmpty(CancellationReason))
                            command.Parameters.AddWithValue("@CancellationReason", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@CancellationReason", CancellationReason);

                        command.Parameters.AddWithValue("@RefundAmount", RefundAmount);
                        command.Parameters.AddWithValue("@ElapsedDays", ElapsedDays);
                        command.Parameters.AddWithValue("@CancellationDate", CancellationDate);
                        command.Parameters.AddWithValue("@CancelledByUSerID", CancelledByUSerID);

                        return command.ExecuteNonQuery() > 0;

                    }
                }
            }
            catch(Exception ex)
            {

            }
            return false;
        }

        static public bool DeleteSubscriptionCancellation(int SubscriptionCancellationID)
        {
            string query = "Delete From SubscriptionCancellations where SubscriptionCancellationID=@SubscriptionCancellationID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubscriptionCancellationID", SubscriptionCancellationID);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return false;
        }

        static public bool Find(int SubscriptionCancellationID,ref int SubscriptionID,ref string CancellationReason,ref double RefundAmount,ref byte ElapsedDays,
           ref DateTime CancellationDate,ref int CancelledByUSerID)
        {
            string query = "select *from SubscriptionCancellations where SubscriptionCancellationID=@SubscriptionCancellationID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubscriptionCancellationID", SubscriptionCancellationID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            SubscriptionID = (int)reader["SubscriptionID"];
                            CancellationReason = (string)reader["CancellationReason"];
                            RefundAmount = (double)reader["RefundAmount"];
                            ElapsedDays = (byte)reader["ElapsedDays"];
                            CancellationDate = (DateTime)reader["CancellationDate"];
                            CancelledByUSerID = (int)reader["CancelledByUSerID"];

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
