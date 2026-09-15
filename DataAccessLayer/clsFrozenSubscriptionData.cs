using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsFrozenSubscriptionData
    {



        public static int AddNewFrozenSubscriptionData(int SubscriptionID,DateTime FreezeStartDate,DateTime FreezeEndDate,DateTime UnFreezeDate,byte FreezingDuration,double FreezeFee,
            string FreezeReason,bool IsFeesPaid,bool IsFrozen, int FrozenByUserID,int unfrozenByUserID)
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
               Select scope_Idintity();  ";


            try
            {

                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand cmd =new SqlCommand(query,conn))
                {

                    conn.Open();

                    cmd.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                    cmd.Parameters.AddWithValue("@FreezeStartDate", FreezeStartDate);
                    cmd.Parameters.AddWithValue("@FreezeEndDate", FreezeEndDate);
                    cmd.Parameters.AddWithValue("@UnFreezeDate", UnFreezeDate);
                    cmd.Parameters.AddWithValue("@FreezingDuration", FreezingDuration);
                    cmd.Parameters.AddWithValue("@FreezeFee", FreezeFee);
                    cmd.Parameters.AddWithValue("@FreezeReason", FreezeReason);
                    cmd.Parameters.AddWithValue("@IsFeesPaid", IsFeesPaid);
                    cmd.Parameters.AddWithValue("@IsFrozen", IsFrozen);
                    cmd.Parameters.AddWithValue("@FrozenByUserID", FrozenByUserID);
                    cmd.Parameters.AddWithValue("@unfrozenByUserID", unfrozenByUserID);


                    object Resault = cmd.ExecuteScalar();
                    if (int.TryParse(Resault.ToString(), out int FrozenID))
                    {
                        return FrozenID;
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


      







    }
}
