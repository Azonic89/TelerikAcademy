namespace SpecialSymbolsSearch
{
    using System;
    using System.Data.SqlClient;

    using ServerAddress;

    public class StartUp
    {
        private static void Main()
        {
            Console.Write("Enter a pattern string to search by: ");
            var pattern = Console.ReadLine();

            SearchProductNameByPattern(pattern);
        }
        private static void SearchProductNameByPattern(string pattern)
        {
            using (var dbConnection = new SqlConnection(ConnectionString.ServerConnectionString))
            {
                dbConnection.Open();
                var sqlCommand = GetSearchByPatternSqlCommand(dbConnection, pattern);

                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productName = reader["ProductName"];

                        Console.WriteLine(" - " + productName);
                    }
                }
            }
        }

        private static SqlCommand GetSearchByPatternSqlCommand(SqlConnection sqlConnection, string pattern)
        {
            var sqlCommand = new SqlCommand(@"SELECT ProductName
                                                     FROM Products
                                                     WHERE CHARINDEX(@pattern, ProductName) > 0", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@pattern", pattern);
            return sqlCommand;
        }
    }
}
