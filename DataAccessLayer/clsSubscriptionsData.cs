using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsSubscriptionsData
    {




        public static int AddNewSubscription(int MemberID,
             int PlanID, DateTime StartDate, DateTime ExpirationDate, double Price, bool IsActive, int CreatedByUserID)
        {


            string sql = "INSERT INTO Subscriptions (MemberID, PlanID, StartDate, ExpirationDate, Price, IsActive, CreatedByUserID) " +
                         "VALUES (@MemberID, @PlanID, @StartDate, @ExpirationDate, @Price, @IsActive, @CreatedByUserID); " +
                         "SELECT SCOPE_IDENTITY();"; // This will return the last inserted identity value


            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@PlanID", PlanID);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        return insertedID;
                    }
                    else
                        return -1;

                }


            }
            catch (Exception ex)
            {

                return -1;

            }

        }

        public static bool UpdateSubscription(int SubscriptionID, int MemberID,
             int PlanID, DateTime StartDate, DateTime ExpirationDate, double Price, bool IsActive, int CreatedByUserID)
        {
            string sql = "UPDATE Subscriptions SET MemberID = @MemberID, PlanID = @PlanID, StartDate = @StartDate, ExpirationDate = @ExpirationDate, Price = @Price, IsActive = @IsActive, CreatedByUserID = @CreatedByUserID " +
                         "WHERE SubscriptionID = @SubscriptionID";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@PlanID", PlanID);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public static bool DeleteSubscription(int SubscriptionID)
        {
            string sql = "DELETE FROM Subscriptions WHERE SubscriptionID = @SubscriptionID";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }



        }

        public static DataTable GetAllSubscriptions()
        {


            string sql = @"
                     SELECT SubscriptionID as 'Subscription ID' ,People.FirstName+' '+People.SecondName+' '+ People.LastName as 'Member Name' 
                      ,  subscriptions.PlanID as 'Plan ID', StartDate as 'Start Date', ExpirationDate as 
                 'Expiration Date', subscriptions.Price as 'Price', subscriptions.IsActive as 'Is Active', subscriptions.CreatedByUserID as
                'Created By User ID' from Subscriptions join Members on Subscriptions.MemberID=Members.MemberID join People on Members.PersonID=People.ID
                join SubscriptionPlans on SubscriptionPlans.PlanID =subscriptions.PlanID

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

        public static bool FindSubscriptionBySubscriptionID(int SubscriptionID, ref int MemberID, ref int PlanID, ref DateTime StartDate, ref DateTime ExpirationDate,
            ref double Price, ref bool IsActive, ref int CreatedByUserID)
        {


            string sql = "SELECT MemberID, PlanID, StartDate, ExpirationDate, Price, IsActive, CreatedByUserID FROM Subscriptions WHERE SubscriptionID = @SubscriptionID";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MemberID = (int)reader["MemberID"];
                            PlanID = (int)reader["PlanID"];
                            StartDate = (DateTime)reader["StartDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
                            Price = (double)reader["Price"];
                            IsActive = (bool)reader["IsActive"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];


                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool FindSubscriptionByMemberID(int MemberID, ref int SubscriptionID, ref int PlanID, ref DateTime StartDate, ref DateTime ExpirationDate,
            ref double Price, ref bool IsActive, ref int CreatedByUserID)
        {

            string sql = "SELECT SubscriptionID, PlanID, StartDate, ExpirationDate, Price, IsActive, CreatedByUserID FROM Subscriptions WHERE MemberID = @MemberID";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SubscriptionID = (int)reader["SubscriptionID"];
                            PlanID = (int)reader["PlanID"];
                            StartDate = (DateTime)reader["StartDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
                            Price = (double)reader["Price"];
                            IsActive = (bool)reader["IsActive"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];


                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


                
        //public static bool UpdateSubscriptionStatus(int SubscriptionID, bool IsActive)
        //{
        //    string sql = "UPDATE Subscriptions SET IsActive = @IsActive WHERE SubscriptionID = @SubscriptionID";
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
        //        using (SqlCommand command = new SqlCommand(sql, conn))
        //        {
        //            command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
        //            command.Parameters.AddWithValue("@IsActive", IsActive);
        //            return command.ExecuteNonQuery() > 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}



    }
                    
}
