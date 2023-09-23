/*using Microsoft.AspNetCore.Hosting.Server;
using System.Security.Cryptography.Xml;
using Microsoft.Data.SqlClient;
*/
using Microsoft.Data.SqlClient;

namespace FirstMVCApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=200411LTP2726\SQLEXPRESS;database=Testdb;
            integrated security = true;Encrypt = false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
