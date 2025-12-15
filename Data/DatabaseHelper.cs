using System.Configuration;
using Microsoft.Data.SqlClient;

namespace test2.Data
{
  /// <summary>
    /// Lop ho tro ket noi database
    /// </summary>
    public static class DatabaseHelper
    {
     private static string? _connectionString;

        public static string ConnectionString
        {
      get
            {
 if (string.IsNullOrEmpty(_connectionString))
  {
         _connectionString = ConfigurationManager
     .ConnectionStrings["DefaultConnection"]?.ConnectionString
   ?? "Server=localhost;Database=KTPM;Trusted_Connection=True;TrustServerCertificate=True;";
                }
            return _connectionString;
         }
      }

        /// <summary>
 /// Tao ket noi moi toi database
   /// </summary>
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        /// <summary>
     /// Kiem tra ket noi database
     /// </summary>
        public static bool TestConnection()
        {
            try
            {
  using var connection = CreateConnection();
  connection.Open();
     return true;
   }
          catch
         {
  return false;
          }
        }

        /// <summary>
        /// Kiem tra ket noi va tra ve thong bao
        /// </summary>
   public static (bool Success, string Message) TestConnectionWithMessage()
        {
    try
        {
    using var connection = CreateConnection();
         connection.Open();
   return (true, $"Ket noi thanh cong toi database: {connection.Database}");
    }
       catch (Exception ex)
            {
        return (false, $"Loi ket noi: {ex.Message}");
       }
        }
    }
}
