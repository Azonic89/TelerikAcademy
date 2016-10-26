namespace NumberOfRowsInCat
{
    using System;
    using System.Data.SqlClient;
    
    using ServerAddress;

    public class StartUp
    {
        private static void Main()
        {
            GetNumberOfRowsInCategory();
        }

        private static void GetNumberOfRowsInCategory()
        {
            var dbConnection = new SqlConnection(ConnectionString.ServerConnectionString);

            dbConnection.Open();

            using (dbConnection)
            {
                var sqlCommand = GetSqlCommand(dbConnection);

                var numberOfRows = (int)sqlCommand.ExecuteScalar();

                Console.WriteLine($"Number of rows in Category: {numberOfRows}");
            }
        }

        private static SqlCommand GetSqlCommand(SqlConnection sqlConnection)
        {
            var sqlCommand = new SqlCommand(@"SELECT COUNT(CategoryID)  FROM Categories", sqlConnection);

            return sqlCommand;
        }
    }
}
