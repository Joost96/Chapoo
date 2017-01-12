using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace DAL
{
    public class BestellingDAO
    {
        public static List<BestellingProduct> ReadAllFromBestellingProducten(int bestellingId)
        {
            {
                List<BestellingProduct> BestellingProducten = new List<BestellingProduct>();
                Bestelling bestelling = null;
                SqlConnection conn = Connection.GetConnection("naam");
                conn.Open();
                string sqlBestelling = "SELECT b.[Id], b.[commentaar], b.[betaald], b.[betaalmethode], " +
                    "b.[fooi], b.[datum], b.[totaalbedraag]," +
                    "w.[w_nr], w.[voornaam], w.[achternaam], w.[rol], w.[wachtwoord], w.[username], " +
                    "t.[tafel_nr], t.[t_status], t.[zitplaatsen]" +
                    "FROM [RBS_1617F_db01].[dbo].[BESTELLING] b" +
                    "JOIN [RBS_1617F_db01].[dbo].[Werknemer] w ON b.[WerkNemerId] = w.[w_nr]" +
                    "JOIN [RBS_1617F_db01].[dbo].[Tafel] t ON b.[TafelId] = t.[tafel_nr]" +
                    "WHERE Id = @BestellingId";
                string sqlProducten = "SELECT p.[id], p.[Naam], [prijs], [omschrijving], [voorraad], " +
                    "[commentaar], [naam], [prijs], [omschrijving], [betaald], [datum], [totaalbedrag], [fooi]" +
                    "FROM [RBS_1617F_db01].[dbo].[PRODUCTEN_IN_BESTELLING] pb" +
                    "JOIN [RBS_1617F_db01].[dbo].[PRODUCT] p ON p.ProductId = pb.ProductId" +
                    "WHERE BestellingId = @BestellingId";
                
                                    
                SqlCommand commandBestelling = new SqlCommand(sqlBestelling, conn);
                SqlCommand commandProducten = new SqlCommand(sqlProducten, conn);

                commandBestelling.Parameters.Add("@BestellingId", System.Data.SqlDbType.VarChar).Value = bestellingId;
                commandProducten.Parameters.Add("@BestellingId", System.Data.SqlDbType.VarChar).Value = bestellingId;

                commandBestelling.Prepare();
                commandProducten.Prepare();

                SqlDataReader readerBestelling = commandBestelling.ExecuteReader();
                SqlDataReader readerProducten = commandProducten.ExecuteReader();

                conn.Close();
                if (readerBestelling.Read())
                {
                    //bestelling
                    int id = readerBestelling.GetInt32(0);
                    string commentaar = readerBestelling.GetString(1);
                    bool betaald = readerBestelling.GetBoolean(2);
                    BestellingStatus status = (BestellingStatus)readerBestelling.GetInt32(3);
                    double fooi = readerBestelling.GetDouble(4);
                    DateTime datum = readerBestelling.GetDateTime(5);
                    double totaalBedrag = readerBestelling.GetDouble(6);
                    //werknemer
                    int werknemerId = readerBestelling.GetInt32(7);
                    string voornaam = readerBestelling.GetString(8);
                    string achternaam = readerBestelling.GetString(9);
                    WerknemerRol rol = (WerknemerRol)readerBestelling.GetInt32(10);
                    string wachtwoord = readerBestelling.GetString(11);
                    string gebruikersnaam = readerBestelling.GetString(12);
                    //tafel
                    int tafelNummer = readerBestelling.GetInt32(13);
                    TafelStatus statusTafel = (TafelStatus)readerBestelling.GetInt32(14);
                    int zitplaatsen = readerBestelling.GetInt32(15);
                                
                    Werknemer werknemer = new Werknemer(werknemerId, voornaam, achternaam, gebruikersnaam, wachtwoord, rol);
                    Tafel tafel = new Tafel(tafelNummer, statusTafel, zitplaatsen);
                    bestelling = new Bestelling(bestellingId,werknemer,tafel, commentaar, betaald, fooi, datum, totaalBedrag , BestellingProducten);
                }
                while (readerProducten.Read())
                {
                    string naam = readerProducten.GetString(2);
                    double prijs = readerProducten.GetDouble(3);
                    int voorraad = readerProducten.GetInt32(4);
                    int aantal = readerProducten.GetInt32(5);
                    string commentaar = readerProducten.GetString(6);
                    string tijd = readerProducten.GetString(7);
                }
                conn.Close();
                return BestellingProducten;
            }
        }

        public static void  Update (List<BestellingProduct> bestellingen)
        {

        }

    }

    

}
