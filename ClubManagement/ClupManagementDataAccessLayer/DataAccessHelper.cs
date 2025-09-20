using System.Data.SqlClient;

namespace ClupManagementDataAccessLayer
{
    internal class DataAccessHelper
    {
        private static readonly string _connectionString =
"Server=localhost;Database=ClupManagement;User Id=sa;Password=123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
