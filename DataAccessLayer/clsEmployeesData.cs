using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   static public class clsEmployeesData
    {
        static public DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();
            string query = "select EmployeeID as 'Employee ID',PersonID as 'Person ID',Title,Salary,HiredDate as 'Hired Date'," +
                "TerminationDate as 'Termination Date',Notes,IsActive as 'Is Active',ShiftID as 'Shift ID' from Employees;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString)) 
            using(SqlCommand command=new SqlCommand(query, connection))
            {
                connection.Open();
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
              
            }
            return dt;
        }

        static public bool DeleteEmployee(int EmployeeID)
        {
            string query = " Delete Employees where EmployeeID=@EmployeeID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        static public int AddEmployee(int PersonID,string Title,float Salary,string Notes,bool IsActive,int ShiftID)
        {
            string query = "INSERT INTO [dbo].[Employees]([PersonID],[Title],[Salary],[HiredDate],[Notes],[IsActive],[ShiftID])" +
                " VALUES (@PersonID,@Title,@Salary,@HiredDate,@Notes,@IsActive,@ShiftID); Select scope_Idintity()";

            try
            {
                using (SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PersonID", PersonID);
                        command.Parameters.AddWithValue("Title", Title);
                        command.Parameters.AddWithValue("Salary", Salary);
                        command.Parameters.AddWithValue("HiredDate", DateTime.Now);

            
                        if(string.IsNullOrEmpty(Notes))
                        command.Parameters.AddWithValue("Notes", DBNull.Value);
                        else
                        command.Parameters.AddWithValue("Notes", Notes);

                        command.Parameters.AddWithValue("IsActive", IsActive);
                        command.Parameters.AddWithValue("ShiftID", ShiftID);

                        object Resault = command.ExecuteScalar();

                        if (int.TryParse(Resault.ToString(), out int Value))
                            return Value;
                        else
                            return -1;
                    }
                }
            }
            catch
            {
                return -1;
            }
        }

        static public bool UpdateEmployee(int EmployeeID,int PersonID,string Title,float Salary,DateTime HiredDate,string Notes,bool IsActive,int ShiftID)
        {
            string query = "UPDATE [dbo].[Employees] SET" +
                " [PersonID] =@PersonID," +
                "[Title] =@Title," +
                "[Salary] =@Salary," +
                "[HiredDate] = @HiredDate," +
                "[TerminationDate] = @TerminationDate," +
                "[Notes] = @Notes," +
                "[IsActive] = @IsActive," +
                "[ShiftID] = @ShiftID " +
                "WHERE EmployeeID=@EmployeeID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("PersonID", PersonID);
                        command.Parameters.AddWithValue("Title", Title);
                        command.Parameters.AddWithValue("Salary", Salary);
                        command.Parameters.AddWithValue("HiredDate", HiredDate);


                        if (string.IsNullOrEmpty(Notes))
                        command.Parameters.AddWithValue("Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("Notes", Notes);

                        command.Parameters.AddWithValue("IsActive", IsActive);
                        command.Parameters.AddWithValue("ShiftID", ShiftID);

                        return command.ExecuteNonQuery()> 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        static public bool FindByEmployeeID(int EmployeeID,ref int PersonID,ref string Title,ref float Salary,ref DateTime HiredDate,ref DateTime? TerminationDate,ref string Notes,ref bool IsActive,ref int ShiftID)
        {                                                                                                                                   // ? because allows null .
            string query = "Select *from Employees where EmployeeID=@EmployeeID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("EmployeeID", EmployeeID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                PersonID = (int)reader["PersonID"];
                                Title = (string)reader["Title"];
                                Salary = (float)reader["Salary"];

                                if(reader["HiredDate"]==DBNull.Value)
                                TerminationDate = null;
                                else
                                TerminationDate = (DateTime)reader["TerminationDate"];

                                HiredDate = (DateTime)reader["HiredDate"];

                                if (string.IsNullOrEmpty(Notes))
                                    Notes = string.Empty;
                                else
                                Notes = (string)reader["Notes"];

                                IsActive = (bool)reader["IsActive"];
                                ShiftID = (int)reader["ShiftID"];

                                return true;

                            }

                        }
                    }
                }
            }
            catch(Exception ex)
            {
               
            }

            return false;
        }

        static public bool FindByPersonID(int PersonID, ref int EmployeeID, ref string Title, ref float Salary, ref DateTime HiredDate, ref DateTime? TerminationDate, ref string Notes, ref bool IsActive, ref int ShiftID)
        {                                                                                                                                   // ? because allows null .
            string query = "Select *from Employees where PersonID=@PersonID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                EmployeeID = (int)reader["EmployeeID"];
                                Title = (string)reader["Title"];
                                Salary = (float)reader["Salary"];

                                if (reader["HiredDate"] == DBNull.Value)
                                    TerminationDate = null;
                                else
                                    TerminationDate = (DateTime)reader["TerminationDate"];

                                HiredDate = (DateTime)reader["HiredDate"];

                                if (string.IsNullOrEmpty(Notes))
                                    Notes = string.Empty;
                                else
                                    Notes = (string)reader["Notes"];

                                IsActive = (bool)reader["IsActive"];
                                ShiftID = (int)reader["ShiftID"];

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

        static public bool TerminateEmployee(int EmployeeID)
        {
            string query = "Update Employees set TerminationDate=@TerminationDate,IsActive=0 where EmployeeID=@EmployeeID;";

            try
            {
                using(SqlConnection connection=new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("TerminationDate", DateTime.Now);
                        command.Parameters.AddWithValue("EmployeeID", EmployeeID);

                        return command.ExecuteNonQuery()> 0;
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
