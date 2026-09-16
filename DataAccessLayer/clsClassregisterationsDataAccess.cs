using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static public  class clsClassregisterationsDataAccess
    {
        static public DataTable GetAllClassRegisterationInfo()
        {
            DataTable dt = new DataTable();
            string Query = @"SELECT  ClassRegisterationID AS [Class Registeration ID],   P.FirstName + ' ' + P.SecondName + ' ' + P.LastName AS [Member Full Name],
                   C.ClassName AS [Class Name],  C.StartTime AS [Start Time],ClassRegisterations.RegisterationDate as 'Registeration Date' 
                   FROM ClassRegisterations INNER JOIN Members M  
                   ON M.MemberID = ClassRegisterations.MemberID INNER JOIN People P
                   ON P.ID = M.PersonID INNER JOIN Classes C    ON C.ClassID = ClassRegisterations.ClassID

";

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
            }
            return dt;
        }

        static public bool Find(int ClassRegisterationID, ref int MemberID, ref int ClassID, ref int UserID, ref DateTime RegisterationDate)
        {
            string Query = " select * from ClassRegisterations where ClassRegisterationID = @ClassRegisterationID";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ClassRegisterationID", ClassRegisterationID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        MemberID = (int)reader["memberID"];
                        ClassID = (int)reader["ClassID"];
                        UserID = (int)reader["UserID"];
                        RegisterationDate = (DateTime)reader["RegisterationDate"];
                        return true;
                    }
                }
                return false;
            }
        }
        static public int Add(int MemberID, int ClassID, int UserID, DateTime RegisterationDate)
        {
            string Query = "insert into ClassRegisterations " +
                "values (@MemberID,@ClassID,@UserID,@RegisterationDate); SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                cmd.Parameters.AddWithValue("@MemberID", MemberID);
                cmd.Parameters.AddWithValue("@ClassID", ClassID);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@RegisterationDate", RegisterationDate);
                conn.Open();
                object value = cmd.ExecuteScalar();

                if (value != null && int.TryParse(value.ToString(), out int NewID))
                    return NewID;

            }
            return -1;
        }
        static public bool Update(int ClassRegisterationID, int MemberID, int ClassID, int UserID, DateTime RegisterationDate)
        {
            string Query = "update ClassRegisterations " +
                   "set MemberID =@MemberID ," +
                   "ClassID = @ClassID ," +
                   "UserID =@UserID  ," +
                   "RegisterationDate = @RegisterationDate " +
                   "where ClassRegisterationID = @ClassRegisterationID";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ClassRegisterationID", ClassRegisterationID);
                cmd.Parameters.AddWithValue("@MemberID", MemberID);
                cmd.Parameters.AddWithValue("@ClassID", ClassID);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@RegisterationDate", RegisterationDate);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        static public bool Delete(int ClassRegisterationID)
        {
            string Query = " Delete from ClassRegisterations where ClassRegisterationID =@ClassRegisterationID";
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ClassRegisterationID", ClassRegisterationID);
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        static public DataTable FilterClassRegisterationByMemberID(int MemberID)
        {
            DataTable dt = new DataTable();
            string Query = @"SELECT  CR.ClassRegisterationID  AS [Class Registeration ID],    P.FirstName + ' ' + P.SecondName + ' ' + P.LastName AS [Member Full Name],
                 C.ClassName AS [Class Name],    C.StartTime AS [Start Time],CR.RegisterationDate as 'Registeration Date' FROM ClassRegisterations CR INNER JOIN Members M  ON M.MemberID 
                 = CR.MemberID INNER JOIN People P
                   ON P.ID = M.PersonID INNER JOIN Classes C    ON C.ClassID = CR.ClassID 
                where CR.MemberID =@MemberID";

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@MemberID", MemberID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
            }
            return dt;
        }
        static public DataTable FilterClassRegisterationByClassID(int ClassID)
        {
            DataTable dt = new DataTable();
            string Query = "SELECT \r\n    ClassRegisterationID CR AS [Class Registeration ID],\r\n    P.FirstName + ' ' + P.SecondName + ' ' + P.LastName AS [Member Full Name],\r\n " +
                "   C.ClassName AS [Class Name],\r\n    C.StartTime AS [Start Time]\r\nFROM ClassRegisterations CR\r\nINNER JOIN Members M\r\n    ON M.MemberID = ClassRegisteration.MemberID\r\nINNER JOIN People P\r\n " +
                "   ON P.ID = M.PersonID\r\nINNER JOIN Classes C\r\n    ON C.ClassID = ClassRegisteration.ClassID " +
                "where CR.ClassID = @ClassID;";

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
            }
            return dt;
        }
    }
}
    
