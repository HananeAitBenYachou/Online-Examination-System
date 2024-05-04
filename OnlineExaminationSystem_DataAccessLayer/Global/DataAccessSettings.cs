using System.Configuration;

namespace OnlineExaminationSystem_DataAccessLayer.Global
{
    internal static class DataAccessSettings
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    }
}
