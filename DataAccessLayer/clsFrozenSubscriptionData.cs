using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
               Select scope_Identity(); 
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
            DateTime FreezeEndDate,DateTime FreezeStartDate,DateTime? UnFreezeDate, byte FreezingDuration, double FreezeFee,
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

                    if (UnFreezeDate.HasValue)
                        cmd.Parameters.AddWithValue("@UnFreezeDate", UnFreezeDate);
                    else
                        cmd.Parameters.AddWithValue("@UnFreezeDate", DBNull.Value);




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

        public static bool FindFrozenSubscriptionByFreezeID(int FreezeID, ref int SubscriptionID,
    ref DateTime FreezeStartDate, ref DateTime FreezeEndDate, ref DateTime? UnFreezeDate,
    ref byte FreezingDuration, ref double FreezeFee, ref string FreezeReason,
    ref bool IsFeesPaid, ref bool IsFrozen, ref int FrozenByUserID, ref int unfrozenByUserID)
        {
            bool isFound = false;

            string sql = @"SELECT * FROM FrozenSubscriptions WHERE FreezeID = @FreezeID";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@FreezeID", FreezeID);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            SubscriptionID = (int)reader["SubscriptionID"];
                            FreezeStartDate = (DateTime)reader["FreezeStartDate"];
                            FreezeEndDate = (DateTime)reader["FreezeEndDate"];

                            if (reader["UnFreezeDate"] != DBNull.Value)
                                UnFreezeDate = (DateTime)reader["UnFreezeDate"];
                            else
                                UnFreezeDate = null;

                                FreezingDuration = (byte)reader["FreezingDuration"];
                            FreezeFee = reader["FreezeFee"] != DBNull.Value ? (double)reader["FreezeFee"] : 0.0;
                            FreezeReason = reader["FreezeReason"] != DBNull.Value ? (string)reader["FreezeReason"]: string.Empty;
                            IsFeesPaid = (bool)reader["IsFeesPaid"];
                            IsFrozen = (bool)reader["IsFrozen"]; 
                            FrozenByUserID = (int)reader["FrozenByUserID"];
                            unfrozenByUserID = reader["unfrozenByUserID"] != DBNull.Value ? (int)reader["unfrozenByUserID"] : -1;
                        }
                        else
                        {
                            isFound = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }
        public static bool FindFrozenSubscriptionBySubscriptionID(int SubscriptionID, ref int FreezeID,
    ref DateTime FreezeStartDate, ref DateTime FreezeEndDate, ref DateTime? UnFreezeDate,
    ref byte FreezingDuration, ref double FreezeFee, ref string FreezeReason,
    ref bool IsFeesPaid, ref bool IsFrozen, ref int FrozenByUserID, ref int unfrozenByUserID)
        {
            bool isFound = false;

            string sql = @"SELECT * FROM FrozenSubscriptions 
                   WHERE SubscriptionID = @SubscriptionID ";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            FreezeID = (int)reader["FreezeID"];
                            FreezeStartDate = (DateTime)reader["FreezeStartDate"];
                            FreezeEndDate = (DateTime)reader["FreezeEndDate"];

                            if (reader["UnFreezeDate"] != DBNull.Value)
                                UnFreezeDate = (DateTime)reader["UnFreezeDate"];
                            else
                                UnFreezeDate = null;

                            FreezingDuration = (byte)reader["FreezingDuration"];
                            FreezeFee = reader["FreezeFee"] != DBNull.Value ? Convert.ToDouble(reader["FreezeFee"]) : 0.0;
                            FreezeReason = reader["FreezeReason"] != DBNull.Value ? (string)reader["FreezeReason"] : string.Empty;
                            IsFeesPaid = (bool)reader["IsFeesPaid"];
                            IsFrozen = (bool)reader["IsFrozen"];
                            FrozenByUserID = (int)reader["FrozenByUserID"];
                            unfrozenByUserID = reader["unfrozenByUserID"] != DBNull.Value ? (int)reader["unfrozenByUserID"] : -1;
                        }
                        else
                        {
                            isFound = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }




    }
}
