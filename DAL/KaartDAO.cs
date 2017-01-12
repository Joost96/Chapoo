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

    //Shahin
    public class KaartDAO
    {
        public List<Product>Read(int KaartId)
        {
            SqlConnection conn = Connection.GetConnection("naam");
            conn.Open();
            string sql = "SELECT [naam], [prijs]" +
                "FROM [RBS_1617F_db01].[dbo].[PRODUCT]" +
                "JOIN [RBS_1617F_db01].[dbo].[KAART] ON KAART.id = PRODUCT.KaartId" +
                "WHERE KaartId = @KaartId";


            //KaartId
            //lunch = 1
            //diner = 2
            //drank = 3
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@KaartId", System.Data.SqlDbType.Int).Value = KaartId;
            command.Prepare();
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();

            List<Product> menuKaart = new List<Product>();
            while (reader.Read())
            {
                string naam = reader.GetString(0);
                double prijs = reader.GetDouble(1);
                menuKaart.Add(new Product(naam, prijs));
            }
            conn.Close();
            return menuKaart;
        }

    }
}
