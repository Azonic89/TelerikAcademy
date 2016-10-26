namespace NameAndDescInCat
{
    using System;
    using System.Data.SqlClient;

    using ServerAddress;

    public class StartUp
    {
        private static void Main()
        {
            GetCategoriesFromDatabase();
        }

        private static void GetCategoriesFromDatabase()
        {
            using (var dbConnection = new SqlConnection(ConnectionString.ServerConnectionString)) 
            {
                dbConnection.Open();
                var sqlCommand = GetSqlCommand(dbConnection);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Category: {reader["CategoryName"]} -> {reader["Description"]}");
                    }
                }
            }
        }

        private static SqlCommand GetSqlCommand(SqlConnection sqlConnection)
        {
            var sqlCommand = new SqlCommand(@"SELECT CategoryName, Description FROM Categories", sqlConnection);

            return sqlCommand;
        }
    }
}
