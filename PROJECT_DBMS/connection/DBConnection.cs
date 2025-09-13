using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace PROJECT_DBMS.connection
{
    public class DBConnection
    {
        public static string ConnectionString = "Server=localhost\\HUYLUONG; Database=DeAn; User Id=sa; Password=luongngochuy2005; TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {   
            return new SqlConnection(ConnectionString);
        }
    }
}
