namespace WriteToExcel
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    public class StartUp
    {
        public static void Main()
        {
            WriteToExcel();
        }

        private static void WriteToExcel(int numberOfRecordsToInsert = 10)
        {           
            using (var excelConnection = new OleDbConnection())
            {
                var path = "../NamesAndScores.xlsx";
                // Prolly there would be some provider issues
                excelConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'";

                excelConnection.Open();
                var sheetName = GetSheetName(excelConnection);
                var excelCommand = GetInsertOleDbCommand(excelConnection, sheetName);

                for (var i = 0; i < numberOfRecordsToInsert; i++)
                {
                    var queryResult = excelCommand.ExecuteNonQuery();
                    Console.WriteLine($"({queryResult} row(s) affected)");
                }
            }
        }

        private static string GetSheetName(OleDbConnection oleDbCommand)
        {
            DataTable excelSchema = oleDbCommand.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            var sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();

            return sheetName;
        }

        private static OleDbCommand GetInsertOleDbCommand(OleDbConnection oleDbConnection, string sheetName)
        {
            var name = "Peter Ivanov";
            var age = 25;

            var excelCommand = new OleDbCommand(@"INSERT INTO [" + sheetName + @"]
                                                           VALUES (@name, @age)", oleDbConnection);

            excelCommand.Parameters.AddWithValue("@name", name);
            excelCommand.Parameters.AddWithValue("@age", age);

            return excelCommand;
        }
    }
}
