using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DAL
    {
        private static SqlConnection sqlConnection;
        private static string sqlConnectionString;

        public static string DbConnectionString()
        {
            sqlConnectionString = ConfigurationManager.ConnectionStrings["conexaoSQL"].ConnectionString;
            return sqlConnectionString;
        }

        public static SqlConnection DbConnection()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoSQL"].ConnectionString);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
