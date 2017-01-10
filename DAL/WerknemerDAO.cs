using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DAL
{
    public class WerknemerDAO
    {
       public static Create(string voornaam, string achternaam, int rol, string wachtwoord, string username)
        {
            SqlConnection conn = Connection.GetConnection("naam");
            conn.Open();
            string sql = "INSERT INTO [RBS_1617F_db01].[dbo].[WERKNEMER](voornaam, achternaam, rol, wachtwoord, username) " +
                "VALUES (@voornaam, @achternaam, @rol, @wachtwoord, @username) ";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@voornaam", System.Data.SqlDbType.VarChar).Value = voornaam;
            command.Parameters.Add("@achternaam", System.Data.SqlDbType.VarChar).Value = achternaam;
            command.Parameters.Add("@rol", System.Data.SqlDbType.Int).Value = rol;
            command.Parameters.Add("@wachtwoord", System.Data.SqlDbType.VarChar).Value = wachtwoord;
            command.Parameters.Add("@username", System.Data.SqlDbType.VarChar).Value = username;
            command.Prepare();
            command.ExecuteNonQuery();

        }
           
        public static Delete()
        {

        }
            
        public static getloginid()
        {

        }
        public static GetNextIncrement()
        {

        }

        public static Read()
        {

        }
        public static ReadAll()
        {

        }

        public static Update()
        {

        }
        public WerknemerDAO()
            {
            }





    }
    


}
