using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public static class clsSubscriptionPlansDataAccess
    {
        //PlamID , PlanName , PlanDescription , Availablity, PlanPrice,Duration  , Note .

      public  static bool FindPlanByPlanID(int PlanID, ref string Name, ref string Description, ref bool IsAvailable, ref double Price,ref int Duration, ref string Note)
        {
            string query = $"SELECT Name, Description, IsAvailable, Price,Duration, Note FROM SubscriptionPlans WHERE PlanID = @PlanID";

            //Handle Exception
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    //Open the database Connection 

                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlanID", PlanID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Name = (string)reader["Name"];
                                Duration = (int)reader["Duration"];
                                Description = (string)reader["Description"];
                                //edit spelling mistake
                                IsAvailable = (bool)reader["IsAvailable"];
                                Price = (double)reader["Price"];
                                if (reader["Note"] == DBNull.Value)
                                    Note = string.Empty;
                                else
                                    Note = (string)reader["Note"];
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
        public static bool FindPlanByPlanName(string PlanName, ref int PlanID, ref string Description, ref bool IsAvailable, ref double Price, ref int Duration, ref string Note)
        {
            string query = $"SELECT PlanID, Description, IsAvailable, Price,Duration, Note FROM SubscriptionPlans WHERE Name = @PlanName";

            //Handle Exception
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    //Open the database Connection 

                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlanName", PlanName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PlanID = (int)reader["PlanID"];
                                Duration = (int)reader["Duration"];
                                Description = (string)reader["Description"];
                                //edit spelling mistake
                                IsAvailable = (bool)reader["IsAvailable"];
                                Price = Convert.ToDouble( reader["Price"]);
                                if (reader["Note"] == DBNull.Value)
                                    Note = string.Empty;
                                else
                                    Note = (string)reader["Note"];
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

        public static int Add(string Name, string Description, bool IsAvailable, double Price,int Duration, string Note)
        {
            string Query = " insert into SubscriptionPlans \r\nvalues (@Name,@Description,@IsAvailable,@Price,@Note,@Duration) ; SELECT SCOPE_IDENTITY(); ";

            //Handle Exception

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    //Open the database Connection 

                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Duration", Duration);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@IsAvailable", IsAvailable);
                        cmd.Parameters.AddWithValue("@Price", Price);
                        if (!string.IsNullOrEmpty(Note))
                            cmd.Parameters.AddWithValue("@Note", Note);
                        else
                            cmd.Parameters.AddWithValue("@Note", DBNull.Value);

                        object Result = cmd.ExecuteScalar();

                        if (Result !=null && int.TryParse(Result.ToString(), out int value))
                            return value;
                        else
                            return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
       public static bool Update(int PlanID,string Name, string Description, bool IsAvailable, double Price,int Duration, string Note)
        {
            // edit spelling mistake in Availiablity
            //add Price parameter to the query
            string Query = "\r\nupdate SubscriptionPlans \r\nset Name= @Name, Description = @Description,Price=@Price, IsAvailable= @IsAvailable, Note = @Note,Duration=@Duration \r\nwhere PlanID = @PlanID  ";

            //Handle Exception
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    //Open the database Connection
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        //Add parameters to the command object Plan ID

                        cmd.Parameters.AddWithValue("@PlanID", Name);
                        cmd.Parameters.AddWithValue("@Duration", Duration);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Description", Description);

                        //edit spelling mistake in Availiablity
                        cmd.Parameters.AddWithValue("@IsAvailable", IsAvailable);
                        cmd.Parameters.AddWithValue("@Price", Price);

                        if (!string.IsNullOrEmpty(Note))
                            cmd.Parameters.AddWithValue("@Note", Note);
                        else
                            cmd.Parameters.AddWithValue("@Note", DBNull.Value);
                        return Convert.ToInt32(cmd.ExecuteNonQuery()) > 0;

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static bool Delete(int PlanID)
        {
            string Query = "Delete From SubscriptionPlans where PlanID = @PlanID";
            //Handle Exception
            try
            {

                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    //Open the database Connection
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlanID", PlanID);
                        return Convert.ToInt32(cmd.ExecuteNonQuery()) > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool SetAvailability(int PlanID, bool IsAvailable)
        {
            string Query = " Update SubscriptionPlans set IsAvailable =@IsAvailable where PlanID = @PlanID ";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    //Open the database Connection
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlanID", PlanID);
                        cmd.Parameters.AddWithValue("@IsAvailable", IsAvailable);

                        return Convert.ToInt32(cmd.ExecuteNonQuery()) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static DataTable GetAllSubscriptionPlans()
        {
            DataTable dt = new DataTable();
            string Query = "select * from SubscriptionPlans ";
            try
            {
                //Handle Exception
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    //Open the database Connection
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }

                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }


        public static DataTable GetAllAvailabilityPlanNames()
        {
            DataTable dt = new DataTable();
            string Query = @"select  Name from SubscriptionPlans ";
            try
            {
                //Handle Exception
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    //Open the database Connection
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }

                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }



    }
}
