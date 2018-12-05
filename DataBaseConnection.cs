using System.Configuration;
using System.Data.SqlClient;

namespace DataBaseConfig
{
    public class DataBaseconnection
    {
        
        public SqlConnection ObtainConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Trial.Properties.Settings.TrainingConnectionString"].ConnectionString;
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            return cnn;
        }
    }
}