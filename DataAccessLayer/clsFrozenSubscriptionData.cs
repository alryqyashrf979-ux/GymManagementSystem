using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsFrozenSubscriptionData
    {



        public static int AddNewFreezeSubscription(int SubscriptionID,DateTime FreezeEndDate,DateTime FreezeStartDate, byte FreezingDuration,double FreezeFee,
            string FreezeReason,bool IsFeesPaid,bool IsFrozen, int FrozenByUserID)
        {

            string query = @"INSERT INTO [dbo].[FrozenSubscriptions]
           ([SubscriptionID]
           ,[FreezeStartDate]
           ,[FreezeEndDate]
           ,[UnFreezeDate]
           ,[FreezingDuration]
           ,[FreezeFee]
           ,[FreezeReason]
           ,[IsFeesPaid]
           ,[Status]
           ,[FrozenByUserID]
           ,[unfrozenByUserID])
     VALUES
           (@SubscriptionID
           ,@FreezeStartDate
           ,@FreezeEndDate
           ,@UnFreezeDate
           ,@FreezingDuration
           ,@FreezeFee
           ,@FreezeReason
           ,@IsFeesPaid
           ,@IsFrozen
           ,@FrozenByUserID
           ,@unfrozenByUserID);
               Select scope_Idintity(); 
                 ";



            try
            {

                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd =new SqlCommand(query,conn))
                {

                    conn.Open();

                    cmd.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                    cmd.Parameters.AddWithValue("@FreezeStartDate", FreezeStartDate);
                    cmd.Parameters.AddWithValue("@FreezeEndDate", FreezeEndDate);

                    cmd.Parameters.AddWithValue("@UnFreezeDate",DateTime.Now);
                    cmd.Parameters.AddWithValue("@FreezingDuration", FreezingDuration);


                    if (FreezeFee > 0)
                        cmd.Parameters.AddWithValue("@FreezeFee", FreezeFee);
                    else
                        cmd.Parameters.AddWithValue("@FreezeFee", DBNull.Value);

                    if (!string.IsNullOrEmpty(FreezeReason))
                        cmd.Parameters.AddWithValue("@FreezeReason", FreezeReason);
                    else
                        cmd.Parameters.AddWithValue("@FreezeReason", DBNull.Value);

                    cmd.Parameters.AddWithValue("@IsFeesPaid", IsFeesPaid);
                    cmd.Parameters.AddWithValue("@IsFrozen", IsFrozen);
                    cmd.Parameters.AddWithValue("@FrozenByUserID", FrozenByUserID);
                    cmd.Parameters.AddWithValue("@unfrozenByUserID", DBNull.Value);


                    object Resault = cmd.ExecuteScalar();
                    if (int.TryParse(Resault.ToString(), out int FreezeID))
                    {
                        return FreezeID;
                    }
                    else
                        return -1;


                }

            }
            catch(Exception ex) 
            { 
            
            return -1;  

            }


        }


        public static bool UpdateFrozenSubscription(int FreezeID, int SubscriptionID,
            DateTime FreezeEndDate,DateTime FreezeStartDate,DateTime UnFreezeDate, byte FreezingDuration, double FreezeFee,
            string FreezeReason, bool IsFeesPaid, bool IsFrozen, int FrozenByUserID,int unfrozenByUserID)
        {

            string sql = @"UPDATE [dbo].[FrozenSubscriptions]
   SET [SubscriptionID] = @SubscriptionID
      ,[FreezeStartDate] = @FreezeStartDate
      ,[FreezeEndDate] = @FreezeEndDate
      ,[UnFreezeDate] = @UnFreezeDate
      ,[FreezingDuration] = @FreezingDuration
      ,[FreezeFee] = @FreezeFee
      ,[FreezeReason] = @FreezeReason
      ,[IsFeesPaid] = @IsFeesPaid
      ,[IsFrozen] = @IsFrozen
      ,[FrozenByUserID] = @FrozenByUserID
      ,[unfrozenByUserID] = @unfrozenByUserID

 WHERE FreezeID=@FreezeID;

 
";

            try
            {


                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    conn.Open();


                    cmd.Parameters.AddWithValue("@FreezeID", FreezeID);
                    cmd.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                    cmd.Parameters.AddWithValue("@FreezeStartDate", FreezeStartDate);
                    cmd.Parameters.AddWithValue("@FreezeEndDate", FreezeEndDate);
                    cmd.Parameters.AddWithValue("@UnFreezeDate", UnFreezeDate);



                    cmd.Parameters.AddWithValue("@IsFrozen", IsFrozen);
                    cmd.Parameters.AddWithValue("@FreezingDuration", FreezingDuration);

                    if (FreezeFee > 0)
                        cmd.Parameters.AddWithValue("@FreezeFee", FreezeFee);
                    else
                        cmd.Parameters.AddWithValue("@FreezeFee", DBNull.Value);

                    if (!string.IsNullOrEmpty(FreezeReason))
                        cmd.Parameters.AddWithValue("@FreezeReason", FreezeReason);
                    else
                        cmd.Parameters.AddWithValue("@FreezeReason", DBNull.Value);

                    cmd.Parameters.AddWithValue("@IsFeesPaid", IsFeesPaid);

                    if(unfrozenByUserID!=-1)
                    cmd.Parameters.AddWithValue("@unfrozenByUserID", unfrozenByUserID);
                    else
                        cmd.Parameters.AddWithValue("@unfrozenByUserID", DBNull.Value);


                    return cmd.ExecuteNonQuery() > 0;

                }

            }
            catch (Exception ex)
            {

                return false;

            }

        }



        public static bool DeleteFrozenSubscription(int FreezeID)
        {

            string sql = "DELETE FROM FrozenSubscriptions WHERE FreezeID = @FreezeID";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@FreezeID", FreezeID);
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public static DataTable GetAllFrozenSubscriptions()
        {


            string sql = @"

                    SELECT 
    FreezeID AS 'Freeze ID',
    SubscriptionID AS 'Subscription ID',
    FreezeStartDate AS 'Start Date',
    FreezeEndDate AS 'End Date',
    UnFreezeDate AS 'UnFreeze Date',
    FreezingDuration AS 'Freezing Duration',
    FreezeFee AS 'Freeze Fee',
    IsFeesPaid AS 'IsFeesPaid',
    IsFrozen AS 'Is Frozen',
    FrozenByUserID AS 'FrozenByUserID',
    unfrozenByUserID AS 'UnFrozenByUserID'

      FROM FrozenSubscriptions;

                     ";

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                using (SqlDataReader Reader = command.ExecuteReader())
                {


                    if (Reader.HasRows)
                    {
                        dt.Load(Reader);
                        return dt;
                    }
                    else
                    {
                        return null;
                    }



                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }









    }
}
