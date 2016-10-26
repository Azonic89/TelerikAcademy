namespace RetrieveImages
{
    using System.Data.SqlClient;
    using System.IO;
    using System.Net.Mime;

    using ServerAddress;

    public class StartUp
    {
        private const int OleMetaFilePictStartPosition = 78;

        public static void Main()
        {
            GetImagesFromDatabase();
        }

        private static void GetImagesFromDatabase()
        {
            using (var dbConnection = new SqlConnection(ConnectionString.ServerConnectionString))
            {
                dbConnection.Open();
                var sqlCommand = GetSqlCommand(dbConnection);

                using (var reader = sqlCommand.ExecuteReader())
                {
                    var imageId = 1;

                    while (reader.Read())
                    {
                        var fileBinaryData = (byte[])reader["Picture"];
                        SaveImageWithOleMetaFilePict(imageId.ToString(), fileBinaryData, ".jpg");
                        imageId++;
                    }
                }
            }
        }

        private static void SaveImageWithOleMetaFilePict(string fileName, byte[] imageBinaryData, string extension)
        {
            var memoryStream =
                new MemoryStream(imageBinaryData, OleMetaFilePictStartPosition, imageBinaryData.Length - OleMetaFilePictStartPosition);

            /* using (memoryStream)
            {
                using (var image = MediaTypeNames.Image(memoryStream))
                {
                    image.Save(fileName + extension);
                }
            } */
        }

        private static SqlCommand GetSqlCommand(SqlConnection sqlConnection)
        {
            var sqlCommand = new SqlCommand(@"SELECT Picture 
                                                     FROM Categories", sqlConnection);
            return sqlCommand;
        }
    }
}
