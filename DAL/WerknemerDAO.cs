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
    public class WerknemerDAO
    {
       public static void Create(string voornaam, string achternaam, int rol, string wachtwoord, string username)
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
            conn.Close();

        }
           
        //public static Delete()
        //{
            
        //}
            
        public Model.Werknemer GetWerknemer(string username)
        {



            Model.Werknemer werknemer = null;


            SqlConnection conn = Connection.GetConnection("naam");
            conn.Open();
            string sql = "SELECT [w_nr], [voornaam], [achternaam], [rol], [wachtwoord], [username] " +
                "FROM [RBS_1617F_db01].[dbo].[WERKNEMER] " +
                "WHERE [username] = @username";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 45).Value = username;
            command.Prepare();
            

            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int Id = reader.GetInt32(0);
                string Voornaam = reader.GetString(1);
                string Achternaam = reader.GetString(2);
                WerknemerRol rol = (WerknemerRol) reader.GetInt32(3);
                string wachtwoord = reader.GetString(4);
                string gebruikersnaam = reader.GetString(5);

                werknemer = new Model.Werknemer(Id, Voornaam, Achternaam, gebruikersnaam, wachtwoord, rol);
               
            }

            conn.Close();
            return werknemer;

            
            



        }
        //public static GetNextIncrement()
        //{

        //}

        //public static Read()
        //{

        //}
        //public static ReadAll()
        //{

        //}

        //public static Update()
        //{

        //}
      





    }
    


}
