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
             int PlanID, DateTime StartDate, DateTime ExpirationDate, double Price, byte Status, int CreatedByUserID)
        {


            string sql = "INSERT INTO Subscriptions (MemberID, PlanID, StartDate, ExpirationDate, Price, Status, CreatedByUserID) " +
                         "VALUES (@MemberID, @PlanID, @StartDate, @ExpirationDate, @Price, @Status, @CreatedByUserID); " +
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
                    command.Parameters.AddWithValue("@Status", Status);
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
             int PlanID, DateTime StartDate, DateTime ExpirationDate, double Price, byte Status, int CreatedByUserID)
        {
            string sql = "UPDATE Subscriptions SET MemberID = @MemberID, PlanID = @PlanID, StartDate = @StartDate, ExpirationDate = @ExpirationDate, Price = @Price, Status = @Status, CreatedByUserID = @CreatedByUserID " +
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
                    command.Parameters.AddWithValue("@Status", Status);
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
                    SELECT 
    SubscriptionID AS 'Subscription ID', 
    People.FirstName + ' ' + People.SecondName + ' ' + People.LastName AS 'Member Name', 
    subscriptions.PlanID AS 'Plan ID', 
    StartDate AS 'Start Date', 
    ExpirationDate AS 'Expiration Date', 
    subscriptions.Price AS 'Price', 
    CASE subscriptions.Status 
        WHEN 1 THEN 'Active'
        WHEN 2 THEN 'Expired'
        WHEN 3 THEN 'Canceled'
        WHEN 4 THEN 'Frozen'
        WHEN 5 THEN 'Changed'
        ELSE 'Unknown'
    END AS 'Status', 
    subscriptions.CreatedByUserID AS 'Created By User ID' 
FROM Subscriptions 
JOIN Members ON Subscriptions.MemberID = Members.MemberID 
JOIN People ON Members.PersonID = People.ID
JOIN SubscriptionPlans ON SubscriptionPlans.PlanID = subscriptions.PlanID;


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
            ref double Price, ref byte Status, ref int CreatedByUserID)
        {


            string sql = "SELECT MemberID, PlanID, StartDate, ExpirationDate, Price, Status, CreatedByUserID FROM Subscriptions WHERE SubscriptionID = @SubscriptionID";
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
                            Status = (byte)reader["Status"];
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
            ref double Price, ref byte Status, ref int CreatedByUserID)
        {

            string sql = "SELECT SubscriptionID, PlanID, StartDate, ExpirationDate, Price, Status, CreatedByUserID FROM Subscriptions WHERE MemberID = @MemberID";
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
                            Status = (byte)reader["Status"];
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



        public static bool UpdateSubscriptionStatus(int SubscriptionID, byte Status)
        {
            string sql = "UPDATE Subscriptions SET Status = @Status WHERE SubscriptionID = @SubscriptionID";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
                    command.Parameters.AddWithValue("@Status", Status);
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        static public double SelectPriceFromSubscription(int SubscriptionID)
        {
            string query = "select Price from Subscription where SubscriptionID=@SubscriptionID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("SubscriptionID", SubscriptionID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                        return (double)reader["Price"];
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return 0;
           
        }

    }
                    
}
