using Microsoft.Data.SqlClient;

namespace IPB2.OnlineBusSystem.WebApi.Common
{
    public static class ConnectionString
    {

        public static SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "IPB2_OnlineBusBooking",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true,
        };

        public static string GetConnection()
        {
            return connectionString.ConnectionString;
        }
    }
}
