using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DAL
{
    class Connection
    {
        string naam;


        public static SqlConnection GetConnection (string naam)
        {
            string connstring = ConfigurationManager.ConnectionStrings[naam].ConnectionString;
            return new SqlConnection(connstring);
        }


    }
}
