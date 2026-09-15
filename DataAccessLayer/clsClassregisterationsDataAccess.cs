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
            string Query = "SELECT \r\n    ClassRegisterationID AS [Class Registeration ID],\r\n    P.FirstName + ' ' + P.SecondName + ' ' + P.LastName AS [Member Full Name],\r\n " +
                "   C.ClassName AS [Class Name],\r\n    C.StartTime AS [Start Time]\r\nFROM ClassRegisterations\r\nINNER JOIN Members M\r\n    ON M.MemberID = ClassRegisteration.MemberID\r\nINNER JOIN People P\r\n " +
                "   ON P.ID = M.PersonID\r\nINNER JOIN Classes C\r\n    ON C.ClassID = ClassRegisteration.ClassID;";

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
