using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Model;

namespace DAL
{
    public class BestellingDAO
    {
        public static void Create()

        {
            SqlConnection conn = Connection.GetConnection("naam");
            conn.Open();
            string sql = "INSERT INTO [t_status], [zitplaatsen], [tafel_nr]" +
                "FROM [RBS_1617F_db01].[dbo].[WERKNEMER] ";
            SqlCommand command = new SqlCommand(sql, conn);


            command.Prepare();
            command.ExecuteNonQuery();
        }


    }
}
