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
        public Bestelling ReadBestellingById(int bestellingId)
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
                string sqlProducten = "SELECT p.[id], p.[Naam], p.[prijs], p.[omschrijving], p.[voorraad], " +
                    "pb.[aantal], pb.[tijd], pb.[prijs], pb.[commentaar], " +
                    "c.[id], c.[naam], c.[btw], " +
                    "k.[id], k.[naam], k.[is_keuken]" +
                    "FROM [RBS_1617F_db01].[dbo].[PRODUCTEN_IN_BESTELLING] pb" +
                    "JOIN [RBS_1617F_db01].[dbo].[PRODUCT] p ON p.ProductId = pb.ProductId" +
                    "JOIN [RBS_1617F_db01].[dbo].[Category] p ON c.Id = p.CategoryId" +
                    "JOIN [RBS_1617F_db01].[dbo].[Kaart] k ON k.Id = c.KaartId" +
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
                    BetaalMethode betaalMethode = (BetaalMethode)readerBestelling.GetInt32(3);
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
                    bestelling = new Bestelling(bestellingId,werknemer,tafel, commentaar, betaald, betaalMethode, fooi, datum, totaalBedrag , BestellingProducten);
                }
                while (readerProducten.Read())
                {
                    //bestellingProduct
                    int id = readerProducten.GetInt32(0);
                    string naam = readerProducten.GetString(1);
                    double prijs = (double)readerProducten.GetDecimal(2);
                    string omschrijving = readerProducten.GetString(3);
                    int voorraad = readerProducten.GetInt32(4);
                    BestellingStatus productStatus = (BestellingStatus)readerBestelling.GetInt32(5);
                    int aantal = readerProducten.GetInt32(6);
                    DateTime tijd = readerProducten.GetDateTime(7);
                    string commentaar = readerProducten.GetString(8);
                    //category
                    int categoryId = readerProducten.GetInt32(9);
                    string categoryNaam = readerProducten.GetString(10);
                    int btw = readerProducten.GetInt32(11);
                    //kaart
                    int kaartId = readerProducten.GetInt32(12);
                    string kaartNaam = readerProducten.GetString(13);
                    bool isKeuken = readerProducten.GetBoolean(14);

                    Kaart kaart = new Kaart(kaartId, isKeuken, kaartNaam);
                    Category category = new Category(btw, categoryId, categoryNaam, kaart);
                    BestellingProduct bestellingproduct = new BestellingProduct(id, omschrijving, naam, prijs, voorraad, aantal, commentaar, tijd, productStatus, category);
                    bestelling.AddProduct(bestellingproduct);
                }
                
                conn.Close();
                return bestelling;
            }
        }

        public void AddProductToBestelling(BestellingProduct product)
        {

        }

        public  void UpdateBetaalStatus(int bestellingId, int betaalmethode, double fooi, double totaalbedrag)
        {
            SqlConnection conn = Connection.GetConnection("naam");
            conn.Open();
            string sql = "INSERT INTO [RBS_1617F_db01].[dbo].[BESTELLING](betaalmethode, fooi, totaalbedrag) " +
                "VALUES (@betaalmethode, @fooi, @totaalbedrag) " +
                "WHERE id = @bestellingId";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@bestellingId", System.Data.SqlDbType.Int).Value = bestellingId;
            command.Parameters.Add("@betaalmethode", System.Data.SqlDbType.Int).Value = betaalmethode;
            command.Parameters.Add("@fooi", System.Data.SqlDbType.Decimal).Value = fooi;
            command.Parameters.Add("@totaalbedrag", System.Data.SqlDbType.Decimal).Value = totaalbedrag;
            command.Prepare();
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
