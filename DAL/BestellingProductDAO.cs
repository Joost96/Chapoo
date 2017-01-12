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
    public class BestellingProductDAO
    {
        public static List<BestellingProduct> ReadAllFromBestellingProducten(int bestellingId)
        {
            {
                List<BestellingProduct> BestellingProducten = new List<BestellingProduct>();
                SqlConnection conn = Connection.GetConnection("naam");
                conn.Open();
                string sql = "SELECT [BestellingId], [Omschrijving], [b_status], [aantal], [tijd], [commentaar], [naam], [prijs], [omschrijving], [betaald], [datum], [totaalbedrag], [fooi]" +
                    "FROM [RBS_1617F_db01].[dbo].[PRODUCTEN_IN_BESTELLING]" +
                    "JOIN [RBS_1617F_db01].[dbo].[PRODUCT] ON PRODUCT.ProductId = PRODUCTEN_IN_BESTELLING.ProductId" +
                    "JOIN [RBS_1617F_db01].[dbo].[BESTELLING] ON BESTELLING.id = PRODUCTEN_IN_BESTELLING.BestellingId" +
                    "WHERE BestellingId = @ProductId";
                
                                    
                SqlCommand command = new SqlCommand(sql, conn);
                
                command.Parameters.Add("@BestellingId", System.Data.SqlDbType.VarChar).Value = bestellingId;

                command.Prepare();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string omschrijving = reader.GetString(1);
                    string naam = reader.GetString(2);
                    double prijs = reader.GetDouble(3);
                    int voorraad = reader.GetInt32(4);
                    int aantal = reader.GetInt32(5);
                    string commentaar = reader.GetString(6);
                    string tijd = reader.GetString(7);
                    BestellingStatus status = (BestellingStatus)reader.GetInt32(8);
                    bool betaald = reader.GetBoolean(9);
                    DateTime datum = reader.GetDateTime(10);
                    double totaalBedrag = reader.GetDouble(11);
                    double fooi = reader.GetDouble(12);

                    Bestelling bestelling = new Bestelling(bestellingId, commentaar, betaald, fooi, datum, totaalBedrag);
                    BestellingProducten.Add(new BestellingProduct(id, omschrijving, naam, prijs, voorraad, aantal, bestelling, commentaar, tijd, status));

                    
                }
                conn.Close();
                return BestellingProducten;
            }
        }

        public static void  Update (List<BestellingProduct> bestellingen)
        {
            //Voor bestellingID en PRoductid Pas aantal aan
        }

    }

    

}