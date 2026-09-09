using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer
{
    static class clsSubscriptionPlansDataAccess
    {
        //PlamID , PlanName , PlanDescription , Availablity, PlanPrice  , Note .

        static bool FindPlan(int PlanID, ref string Name, ref string Description, ref bool Availablity, ref decimal Price, ref string Note)
        {
            string query = $"SELECT Name, Description, Availablity, Price, Note FROM SubscriptionPlans WHERE PlanID = @PlanID";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PlanID", PlanID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Name = (string)reader["Name"];
                        Description = (string)reader["Description"];
                        Availablity = (bool)reader["Availiability"];
                        Price = (decimal)reader["Price"];
                        if (reader["Note"] == DBNull.Value)
                            Note = string.Empty;
                        else
                            Note = (string)reader["Note"];
                        return true;
                    }
                }
            }
            return false;
        }

        static int Add(string Name, string Description, bool Availablity, decimal Price, string Note)
        {
            string Query = " insert into SubscriptionPlans \r\nvalues (@Name,@Description,@Availablity,@Price,@Note) ; SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Availablity", Availablity);
                cmd.Parameters.AddWithValue("@Price", Price);
                if (!string.IsNullOrEmpty(Note))
                    cmd.Parameters.AddWithValue("@Note", Note);
                else
                    cmd.Parameters.AddWithValue("@Note", DBNull.Value);

                object Result = cmd.ExecuteScalar();

                if (int.TryParse(Result.ToString(), out int value))
                    return value;
                else
                    return -1;
            }
        }
        static bool Update(string Name, string Description, bool Availiablity, decimal Price, string Note)
        {
            string Query = "\r\nupdate SubscriptionPlans \r\nset Name= @Name, Description = @Description, Availiablity= @AAvailiablity, Note = @Note\r\nwhere PlanID = @PlanID  ";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Availablity", Availiablity);
                cmd.Parameters.AddWithValue("@Price", Price);
                if (!string.IsNullOrEmpty(Note))
                    cmd.Parameters.AddWithValue("@Note", Note);
                else
                    cmd.Parameters.AddWithValue("@Note", DBNull.Value);
                return Convert.ToInt32(cmd.ExecuteNonQuery()) > 0;

            }
        }
        static bool Delete(int PlanID)
        {
            string Query = "Delete From SubscriptionPlans where PlanID = @PlanID";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                cmd.Parameters.AddWithValue("@PlanID", PlanID);
                return Convert.ToInt32(cmd.ExecuteNonQuery()) > 0;
            }
        }
        static bool SetAvailiability(int PlanID , bool Availiability)
        {
            string Query = " Update SubscriptionPlans set Availiablity =@Availiability where PlanID = @PlanID ";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                cmd.Parameters.AddWithValue("@PlanID", PlanID);
                cmd.Parameters.AddWithValue("@Availiability", Availiability);

                return Convert.ToInt32(cmd.ExecuteNonQuery()) > 0;
                }
            }
        }
}
