namespace InsertProduct
{
    using System;
    using System.Data.SqlClient;

    using ServerAddress;

    public class StartUp
    {
        private static void Main()
        {
            InsertProductInCategory();
        }

        private static void InsertProductInCategory()
        {
            using (var dbConnection = new SqlConnection(ConnectionString.ServerConnectionString))
            {
                dbConnection.Open();
                var sqlCommand = GetInsertProductSqlCommand(dbConnection);

                var queryResult = sqlCommand.ExecuteNonQuery();
                Console.WriteLine($"({queryResult} row(s) affected)");
            }
        }

        private static SqlCommand GetInsertProductSqlCommand(SqlConnection sqlConnection)
        {
            var dateTimeNowStamp = DateTime.Now.ToString("ddmmss");

            var productName = "Yeni Raki - " + dateTimeNowStamp;
            var supplierId = 22;
            var categoryId = 1;
            var quantityPerUnit = "20 - 500 ml";
            var unitPrice = 46.0d;
            var unitsInStock = 1000;
            var unitsInOrder = 500;
            var reorderLevel = 30;
            var discontinued = 0;

            var sqlCommand = GetSqlCommand(sqlConnection);
            sqlCommand.Parameters.AddWithValue("@productName", productName);
            sqlCommand.Parameters.AddWithValue("@supplierId", supplierId);
            sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
            sqlCommand.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            sqlCommand.Parameters.AddWithValue("@unitPrice", unitPrice);
            sqlCommand.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            sqlCommand.Parameters.AddWithValue("@unitsInOrder", unitsInOrder);
            sqlCommand.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            sqlCommand.Parameters.AddWithValue("@discontinued", discontinued);
            return sqlCommand;
        }

        private static SqlCommand GetSqlCommand(SqlConnection sqlConnection)
        {
            var sqlCommand =
                new SqlCommand(@"INSERT INTO Products
                                 VALUES (@productName, @supplierId, @categoryId, @quantityPerUnit, @unitPrice, 
                                         @unitsInStock, @unitsInOrder, @reorderLevel, @discontinued)", sqlConnection);
            return sqlCommand;
        }
    }
}
