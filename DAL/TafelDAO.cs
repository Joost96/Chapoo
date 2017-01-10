using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Model;


namespace DAL
{
    public class TafelDAO
    {

        public static bool Update(Tafel tafel)
        {
            bool updatesuccesful = false;
            SqlConnection conn = Connection.GetConnection("naam");
            conn.Open();
            string sql = "UPDATE[RBS_1617F_db01].[dbo].[WERKNEMER](status, zitplaatsen) " +
                "VALUES (@zitplaatsen, @status) ";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@status", System.Data.SqlDbType.Int).Value = tafel.status;
            command.Parameters.Add("@zitplaatsen", System.Data.SqlDbType.Int).Value = tafel.zitplaatsen;

            command.Prepare();
            int rowsaffected = command.ExecuteNonQuery();
            conn.Close();
            if (rowsaffected > 0)
            {
                updatesuccesful = true;
            }

            return updatesuccesful;
        }



    }
}
