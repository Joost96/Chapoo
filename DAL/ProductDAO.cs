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
    public class ProductDAO
    {
        public void UpdateVoorraad(Product product)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            conn.Open();

            string sqlStatement = "UPDATE [dbo].[Producten]" + 
                "SET voorraad = @ParamVoorraad " +
                "WHERE p_nr = @ParamId";
            SqlCommand cmd= new SqlCommand(sqlStatement, conn);
            cmd.Parameters.Add("@ParamVoorraad", System.Data.SqlDbType.Int).Value = (product.Voorraad);
            cmd.Parameters.Add("@ParamId", System.Data.SqlDbType.Int).Value =(product.Id);
            conn.Close();
        }
    }
}
