﻿using System;
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

        public static List<Tafel> ReadAll()
            {
            List<Tafel> TafelOverzicht = new List<Tafel>();
            //    Tafel tafel = new Tafel();
            

            SqlConnection conn = Connection.GetConnection("naam");
            conn.Open();
            string sql = "SELECT [t_status], [zitplaatsen], [tafel_nr]" +
                "FROM [RBS_1617F_db01].[dbo].[WERKNEMER] ";
            SqlCommand command = new SqlCommand(sql, conn);
           

            command.Prepare();
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TafelStatus status = (TafelStatus)reader.GetInt32(0);
                int zitplaatsen = reader.GetInt32(1);
                int tafelnummer = reader.GetInt32(2);


                TafelOverzicht.Add(new Tafel(tafelnummer, status, zitplaatsen));
            }


            return TafelOverzicht;
        }




    }
}