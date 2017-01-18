using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace DAL
{
    public class BestellingDAO
    {
        public Bestelling create(Bestelling bestelling)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();
            string sql = "INSERT INTO [dbo].[BESTELLING] ([WerkNemerId],[TafelId]" +
                ",[betaald],[datum]) " +
                "OUTPUT INSERTED.Id " +
                "VALUES (@werknemerId, @tafelId, @betaald, @datum)";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@werknemerId", System.Data.SqlDbType.Int).Value = bestelling.Bediening.Id;
            command.Parameters.Add("@tafelId", System.Data.SqlDbType.Int).Value = bestelling.TafelBestelling.tafelNummer;
            command.Parameters.Add("@betaald", System.Data.SqlDbType.Bit).Value = bestelling.Betaald;
            command.Parameters.Add("@datum", System.Data.SqlDbType.DateTime).Value = bestelling.Datum;
            command.Prepare();
            int id = (int)command.ExecuteScalar();
            bestelling = new Bestelling(id,bestelling.Bediening,bestelling.TafelBestelling,bestelling.Betaald,bestelling.Datum);
            conn.Close();
            return bestelling;
        }
        public Bestelling ReadBestellingById(int bestellingId)
        {
            {
                List<BestellingProduct> BestellingProducten = new List<BestellingProduct>();
                Bestelling bestelling = null;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                conn.Open();
                string sqlBestelling = "SELECT b.[Id], b.[commentaar], b.[betaald], b.[betaalmethode], " +
                    "b.[fooi], b.[datum], b.[totaalbedrag]," +
                    "w.[w_nr], w.[voornaam], w.[achternaam], w.[rol], w.[wachtwoord], w.[username], " +
                    "t.[tafel_nr], t.[t_status], t.[zitplaatsen] " +
                    "FROM [RBS_1617F_db01].[dbo].[BESTELLING] b " +
                    "JOIN [RBS_1617F_db01].[dbo].[Werknemer] w ON b.[WerkNemerId] = w.[w_nr] " +
                    "JOIN [RBS_1617F_db01].[dbo].[Tafel] t ON b.[TafelId] = t.[tafel_nr] " +
                    "WHERE Id = @BestellingId";
                string sqlProducten = "SELECT p.[p_nr], p.[Naam], p.[prijs], p.[omschrijving], p.[voorraad], " +
                    "pb.[b_status], pb.[aantal], pb.[tijd], pb.[commentaar], " +
                    "c.[id], c.[naam], c.[btw], " +
                    "k.[id], k.[naam], k.[is_keuken] " +
                    "FROM [RBS_1617F_db01].[dbo].[PRODUCTEN_IN_BESTELLING] pb " +
                    "JOIN [RBS_1617F_db01].[dbo].[PRODUCT] p ON p.p_nr = pb.ProductId " +
                    "JOIN [RBS_1617F_db01].[dbo].[Category] c ON c.Id = p.CategoryId " +
                    "JOIN [RBS_1617F_db01].[dbo].[Kaart] k ON k.Id = c.KaartId " +
                    "WHERE BestellingId = @BestellingId";
                
                                    
                SqlCommand commandBestelling = new SqlCommand(sqlBestelling, conn);
                SqlCommand commandProducten = new SqlCommand(sqlProducten, conn);

                commandBestelling.Parameters.Add("@BestellingId", System.Data.SqlDbType.Int).Value = bestellingId;
                commandProducten.Parameters.Add("@BestellingId", System.Data.SqlDbType.Int).Value = bestellingId;

                commandBestelling.Prepare();
                commandProducten.Prepare();

                SqlDataReader readerBestelling = commandBestelling.ExecuteReader();
                SqlDataReader readerProducten = commandProducten.ExecuteReader();
                

                if (readerBestelling.Read())
                {
                    bestelling = createBestellingFormReader(readerBestelling);
                }

                while (readerProducten.Read())
                {
                    //bestellingProduct
                     bestelling.AddProduct(createBestellingProductFromReader(readerProducten, bestelling));
                }
                
                conn.Close();
                return bestelling;
            }
        }
        public Bestelling ReadBestellingByTafelId(int tafelId)
        {
            {
                List<BestellingProduct> BestellingProducten = new List<BestellingProduct>();
                Bestelling bestelling = null;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                conn.Open();
                string sqlBestelling = "SELECT b.[Id], b.[commentaar], b.[betaald], b.[betaalmethode], " +
                    "b.[fooi], b.[datum], b.[totaalbedrag]," +
                    "w.[w_nr], w.[voornaam], w.[achternaam], w.[rol], w.[wachtwoord], w.[username], " +
                    "t.[tafel_nr], t.[t_status], t.[zitplaatsen] " +
                    "FROM [RBS_1617F_db01].[dbo].[BESTELLING] b " +
                    "JOIN [RBS_1617F_db01].[dbo].[Werknemer] w ON b.[WerkNemerId] = w.[w_nr] " +
                    "JOIN [RBS_1617F_db01].[dbo].[Tafel] t ON b.[TafelId] = t.[tafel_nr] " +
                    "WHERE TafelId = @tafelId AND b.betaald = 'false'";
                string sqlProducten = "SELECT p.[p_nr], p.[Naam], p.[prijs], p.[omschrijving], p.[voorraad], " +
                    "pb.[b_status], pb.[aantal], pb.[tijd], pb.[commentaar], " +
                    "c.[id], c.[naam], c.[btw], " +
                    "k.[id], k.[naam], k.[is_keuken] " +
                    "FROM [RBS_1617F_db01].[dbo].[PRODUCTEN_IN_BESTELLING] pb " +
                    "JOIN [RBS_1617F_db01].[dbo].[PRODUCT] p ON p.p_nr = pb.ProductId " +
                    "JOIN [RBS_1617F_db01].[dbo].[Category] c ON c.Id = p.CategoryId " +
                    "JOIN [RBS_1617F_db01].[dbo].[Kaart] k ON k.Id = c.KaartId " +
                    "WHERE BestellingId = @BestellingId";


                SqlCommand commandBestelling = new SqlCommand(sqlBestelling, conn);
                SqlCommand commandProducten = new SqlCommand(sqlProducten, conn);

                commandBestelling.Parameters.Add("@tafelId", System.Data.SqlDbType.Int).Value = tafelId;
                
                commandBestelling.Prepare();
   
                SqlDataReader readerBestelling = commandBestelling.ExecuteReader();

                if (readerBestelling.Read())
                {
                    bestelling = createBestellingFormReader(readerBestelling);
                }
                if (bestelling != null)
                {
                    commandProducten.Parameters.Add("@BestellingId", System.Data.SqlDbType.Int).Value = bestelling.Id;
                    commandProducten.Prepare();
                    SqlDataReader readerProducten = commandProducten.ExecuteReader();
                    while (readerProducten.Read())
                    {
                        //bestellingProduct
                        bestelling.AddProduct(createBestellingProductFromReader(readerProducten,bestelling));
                    }
                }
                conn.Close();
                return bestelling;
            }
        }
        public void AddProductToBestelling(BestellingProduct product)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();
            string sql = "INSERT INTO [RBS_1617F_db01].[dbo].[PRODUCTEN_IN_BESTELLING] " +
                "([ProductId],[BestellingId],[b_status],[aantal],[tijd],[commentaar]) " +
                "VALUES (@ProductId, @BestellingId, @b_status, @aantal, @tijd, @commentaar) ";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@ProductId", System.Data.SqlDbType.Int).Value = product.Id;
            command.Parameters.Add("@BestellingId", System.Data.SqlDbType.Int).Value = product.ProductBestelling.Id;
            command.Parameters.Add("@b_status", System.Data.SqlDbType.Int).Value = (int)product.Status;
            command.Parameters.Add("@aantal", System.Data.SqlDbType.Int).Value = product.Aantal;
            command.Parameters.Add("@tijd", System.Data.SqlDbType.DateTime).Value = product.Tijd;
            command.Parameters.Add("@commentaar", System.Data.SqlDbType.VarChar,45).Value = product.Commentaar;
            command.Prepare();
            command.ExecuteNonQuery();
            conn.Close();
        }
        //Gemaakt door Mark
        public void UpdateBetaalStatus(int tafelId, int betaalmethode, double fooi, double totaalbedrag, string commentaar)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();
            string sql = "UPDATE [RBS_1617F_db01].[dbo].[BESTELLING] " +
                " SET (betaalmethode = @betaalmethode, fooi = @fooi , totaalbedrag = @totaalbedrag , betaald = 1, commentaar = @commentaar) " +
                "WHERE TafelId = @tafelId";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@tafelId", System.Data.SqlDbType.Int).Value = tafelId;
            command.Parameters.Add("@betaalmethode", System.Data.SqlDbType.Int).Value = betaalmethode;
            command.Parameters.Add("@commentaar", System.Data.SqlDbType.VarChar,200).Value = commentaar;

            //Decimal parameters kan ik alleen op deze lelijke manier toevoegen
            SqlParameter fooiparam = new SqlParameter("@fooi", System.Data.SqlDbType.Decimal);
            fooiparam.Value = fooi;
            fooiparam.Precision = 18;
            fooiparam.Scale = 2;


            SqlParameter totaalparam = new SqlParameter("@totaalbedrag", System.Data.SqlDbType.Decimal);
            totaalparam.Value = totaalbedrag;
            totaalparam.Precision = 18;
            totaalparam.Scale = 2;



            command.Prepare();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public List<BestellingProduct>ReadKeukenBarOverzicht(bool isKeuken)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();
            string sql = "SELECT pb.[ProductId], pb.[BestellingId], pb.[b_status], pb.[aantal], pb.[tijd], pb.[commentaar], p.[naam],b.[TafelId]" +
                " FROM[RBS_1617F_db01].[dbo].[PRODUCTEN_IN_BESTELLING] pb " +
                " JOIN[RBS_1617F_db01].[dbo].[PRODUCT] p ON pb.[ProductId] = p.[p_nr] " +
                " JOIN[RBS_1617F_db01].[dbo].[BESTELLING] b ON pb.[BestellingId] = b.[id]" +
                " JOIN [RBS_1617F_db01].[dbo].[KAART] k ON p.[KaartId] = k.[id]" +
                " WHERE k.[is_keuken] = @isKeuken" +
                " order by tijd ";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@isKeuken", System.Data.SqlDbType.Bit).Value = isKeuken;
            command.Prepare();
            SqlDataReader reader = command.ExecuteReader();
            
            List<BestellingProduct> overzicht_K_B = new List<BestellingProduct>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int bestellingId = reader.GetInt32(1);
                int status = reader.GetInt32(2);
                BestellingStatus bStatus = (BestellingStatus)status;
                int aantal = reader.GetInt32(3);
                DateTime tijd = reader.GetDateTime(4);
                string commentaar = reader.GetString(5);
                string naam = reader.GetString(6);
                int tafelId = reader.GetInt32(7);
                BestellingProduct bestellingProduct = new BestellingProduct(id, naam, aantal, commentaar, tijd, bStatus);
                bestellingProduct.ProductBestelling = new Bestelling(bestellingId);
                bestellingProduct.ProductBestelling.TafelBestelling = new Tafel(tafelId);
                overzicht_K_B.Add(bestellingProduct);
            }
            conn.Close();
            return overzicht_K_B;
        }


        private Bestelling createBestellingFormReader(SqlDataReader reader)
        {
            //werknemer
            int werknemerId = reader.GetInt32(7);
            string voornaam = reader.GetString(8);
            string achternaam = reader.GetString(9);
            WerknemerRol rol = (WerknemerRol)reader.GetInt32(10);
            string wachtwoord = reader.GetString(11);
            string gebruikersnaam = reader.GetString(12);

            Werknemer werknemer = new Werknemer(werknemerId, voornaam, achternaam, gebruikersnaam, wachtwoord, rol);

            //tafel
            int tafelNummer = reader.GetInt32(13);
            TafelStatus statusTafel = (TafelStatus)reader.GetInt32(14);
            int zitplaatsen = reader.GetInt32(15);

            Tafel tafel = new Tafel(tafelNummer, statusTafel, zitplaatsen);

            //bestelling
            Bestelling bestelling;
            if (reader.GetBoolean(2)) //is betaald
            {
                int id = reader.GetInt32(0);
                string commentaar = reader.GetString(1);
                bool betaald = reader.GetBoolean(2);
                BetaalMethode betaalMethode = (BetaalMethode)reader.GetInt32(3);
                double fooi = (Double)reader.GetDecimal(4);
                DateTime datum = reader.GetDateTime(5);
                double totaalBedrag = (double)reader.GetDecimal(6);
                bestelling = new Bestelling(id, werknemer, tafel, commentaar, betaald, betaalMethode, fooi, datum, totaalBedrag);
            }
            else
            {
                int id = reader.GetInt32(0);
                bool betaald = reader.GetBoolean(2);
                DateTime datum = reader.GetDateTime(5);
                bestelling = new Bestelling(id, werknemer, tafel, betaald, datum);
            }
            return bestelling;

        }
        private BestellingProduct createBestellingProductFromReader(SqlDataReader reader, Bestelling bestelling)
        {
            //bestellingProduct
            int id = reader.GetInt32(0);
            string naam = reader.GetString(1);
            double prijs = (double)reader.GetDecimal(2);
            string omschrijving = reader.GetString(3);
            int voorraad = reader.GetInt32(4);
            BestellingStatus productStatus = (BestellingStatus)reader.GetInt32(5);
            int aantal = reader.GetInt32(6);
            DateTime tijd = reader.GetDateTime(7);
            string commentaar = reader.GetString(8);
            //category
            int categoryId = reader.GetInt32(9);
            string categoryNaam = reader.GetString(10);
            int btw = reader.GetInt32(11);
            //kaart
            int kaartId = reader.GetInt32(12);
            string kaartNaam = reader.GetString(13);
            bool isKeuken = reader.GetBoolean(14);

            Kaart kaart = new Kaart(kaartId, isKeuken, kaartNaam);
            Category category = new Category(btw, categoryId, categoryNaam, kaart);
            BestellingProduct bestellingProduct = new BestellingProduct(id, omschrijving, naam, prijs, voorraad, aantal, commentaar, tijd, productStatus, category);
            bestellingProduct.ProductBestelling = bestelling;
            return bestellingProduct;
        }

    }
}