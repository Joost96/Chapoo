using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class BestellingProductDAO
    {
        public void updateBestellingProduct(BestellingProduct product , BestellingStatus newStatus)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();
            string sql = "UPDATE [RBS_1617F_db01].[dbo].[PRODUCTEN_IN_BESTELLING] " +
                "SET b_status = @b_status " +
                "WHERE [ProductId] = @ProductId AND BestellingId = @BestellingId AND [tijd] = @Tijd ";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@ProductId", System.Data.SqlDbType.Int).Value = product.Id;
            command.Parameters.Add("@BestellingId", System.Data.SqlDbType.Int).Value = product.ProductBestelling.Id;
            command.Parameters.Add("@b_status", System.Data.SqlDbType.Int).Value = (int)newStatus;
            command.Parameters.Add("@Tijd", System.Data.SqlDbType.DateTime).Value = product.Tijd;
            command.Prepare();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
