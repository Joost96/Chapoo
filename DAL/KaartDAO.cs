﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DAL
{

    //Shahin
    public class KaartDAO
    {
        public List<Product>Read(int KaartId)
        {
            SqlConnection conn = Connection.GetConnection("naam");
            conn.Open();
            string sql = "SELECT p.[p_nr], p.[Naam], p.[prijs], p.[omschrijving], p.[voorraad]" +
                "FROM [RBS_1617F_db01].[dbo].[PRODUCT] AS p " +
                "JOIN [RBS_1617F_db01].[dbo].[KAART] ON KAART.id = p.KaartId " +
                "WHERE KaartId = @KaartId";


            //KaartId
            //lunch = 1
            //diner = 2
            //drank = 3
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@KaartId", System.Data.SqlDbType.Int).Value = KaartId;
            command.Prepare();
            SqlDataReader reader = command.ExecuteReader();

            List<Product> menuKaart = new List<Product>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string naam = reader.GetString(1);
                double prijs = (double)reader.GetDecimal(2);
                string omschrijving = reader.GetString(3);
                int voorraad = reader.GetInt32(4);
                menuKaart.Add(new Product(id, naam,omschrijving, prijs, voorraad));
            }
            conn.Close();
            return menuKaart;
        }

    }
}
