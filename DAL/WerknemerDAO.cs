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
       public void Create(string voornaam, string achternaam, int rol, string wachtwoord, string username)
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
           
       public void Delete(int werknemerId)
       {
           SqlConnection conn = Connection.GetConnection("naam");
           conn.Open();

           string sql = "DELETE " +
               "FROM [RBS_1617F_db01].[dbo].[WERKNEMER]" +
               "WHERE [w_nr] = @ParamId";

           SqlCommand cmd = new SqlCommand(sql, conn);
           
           cmd.Parameters.Add("@ParamId", System.Data.SqlDbType.Int).Value = werknemerId;
           
           cmd.Prepare();
           cmd.ExecuteNonQuery();
           
           conn.Close();
       }
            
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
           
        public List<Werknemer> ReadAll()
        {
            List<Werknemer> werknemers = new List<Werknemer>();
            

        
            SqlConnection conn = Connection.GetConnection("naam");
            conn.Open();
            string sql = "SELECT * " +
                "FROM [RBS_1617F_db01].[dbo].[WERKNEMER] " 
               
                ;
                
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Prepare();


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = reader.GetInt32(0);
                string Voornaam = reader.GetString(1);
                string Achternaam = reader.GetString(2);
                WerknemerRol rol = (WerknemerRol)reader.GetInt32(3);
                string wachtwoord = reader.GetString(4);
                string gebruikersnaam = reader.GetString(5);

                werknemers.Add(new Werknemer(Id, Voornaam, Achternaam, gebruikersnaam, wachtwoord, rol));

            }

            conn.Close();
            return werknemers;

            
            
        }

        public void Update(Werknemer werkNemer)
        {
            SqlConnection conn = new SqlConnection("naam");
            int id = werkNemer.Id;
            string voornaam = werkNemer.Voornaam;
            string achternaam = werkNemer.Achternaam;
            string gebruikersNaam = werkNemer.Gebruikersnaam;
            string w8woord = werkNemer.Wachtwoord;
            int rol = (int)werkNemer.rol;

            conn.Open();

            string sql = "INSERT INTO [RBS_1617F_db01].[dbo].[WERKNEMER]" +
                "VALUES(@ParamId, @Voornaam,@Achternaam, @gebruikersNaam @w8woord @rol)" +
                "WHERE [w_nr] = @ParamId"
                ;

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@ParamId", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Voornaam", System.Data.SqlDbType.VarChar, 45).Value = voornaam;
            cmd.Parameters.Add("@Achternaam", System.Data.SqlDbType.VarChar, 45).Value = achternaam;
            cmd.Parameters.Add("@gebruikersNaam", System.Data.SqlDbType.VarChar,45).Value = gebruikersNaam;
            cmd.Parameters.Add("@w8woord",System.Data.SqlDbType.VarChar,45).Value = w8woord ;
            cmd.Parameters.Add("@rol", System.Data.SqlDbType.Int).Value = rol ;

            cmd.Prepare();
            cmd.ExecuteNonQuery(); ;
            

            conn.Close();
        }
      





    }
    


}
