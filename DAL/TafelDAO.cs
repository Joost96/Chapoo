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
        //gemaakt door mark
        public bool Update(Tafel tafel)
        {
            bool updatesuccesful = false;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();
            string sql = "UPDATE[RBS_1617F_db01].[dbo].[TAFEL](status, zitplaatsen) " +
                "VALUES (@zitplaatsen, @status) " +
                "WHERE tafel_nr = @tafelnummer";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@status", System.Data.SqlDbType.Int).Value = tafel.status;
            command.Parameters.Add("@zitplaatsen", System.Data.SqlDbType.Int).Value = tafel.zitplaatsen;
            command.Parameters.Add("@tafelnummer", System.Data.SqlDbType.Int).Value = tafel.tafelNummer;
            command.Prepare();
            int rowsaffected = command.ExecuteNonQuery();
            conn.Close();
            if (rowsaffected > 0)
            {
                updatesuccesful = true;
            }

            return updatesuccesful;
        }
        //Gemaakt door mark
        public List<Tafel> ReadAll()
            {
            List<Tafel> TafelOverzicht = new List<Tafel>();
            //    Tafel tafel = new Tafel();
            

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();
            string sql = "SELECT [tafel_nr], [t_status], [zitplaatsen]" +
                "FROM [RBS_1617F_db01].[dbo].[TAFEL] ";
            SqlCommand command = new SqlCommand(sql, conn);
           

            command.Prepare();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int tafelnummer = reader.GetInt32(0);
                TafelStatus status = (TafelStatus)reader.GetInt32(1);
                int zitplaatsen = reader.GetInt32(2);
                


                TafelOverzicht.Add(new Tafel(tafelnummer, status, zitplaatsen));
            }


            return TafelOverzicht;
        }


        public Tafel ReadByTafelNummer(int tafelId)
        {
            Tafel tafel = null;


            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();
            string sql = "SELECT [tafel_nr], [t_status], [zitplaatsen]" +
                "FROM [RBS_1617F_db01].[dbo].[TAFEL] " +
                "WHERE tafel_nr = @tafelId";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@tafelId", System.Data.SqlDbType.Int).Value = tafelId;
            command.Prepare();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int tafelnummer = reader.GetInt32(0);
                TafelStatus status = (TafelStatus)reader.GetInt32(1);
                int zitplaatsen = reader.GetInt32(2);
                tafel = new Tafel(tafelnummer, status, zitplaatsen);
            }


            return tafel;
        }

        public void UpdateStatus(int tafelId, int status)
        {
            
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();
            string sql = "UPDATE[RBS_1617F_db01].[dbo].[TAFEL](status) " +
                "VALUES (@status) " +
                "WHERE tafel_nr = @tafelId";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@status", System.Data.SqlDbType.Int).Value = status;
            command.Parameters.Add("@tafelId", System.Data.SqlDbType.Int).Value = tafelId;
            command.Prepare();
           command.ExecuteNonQuery();
            conn.Close();
            

            
        }




    }
}
