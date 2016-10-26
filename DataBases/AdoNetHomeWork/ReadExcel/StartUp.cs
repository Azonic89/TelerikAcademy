namespace ReadExcel
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    public class StartUp
    {
        private static void Main()
        {
            ReadExcelData();
        }

        private static void ReadExcelData()
        {
            using (var excelConnection = new OleDbConnection())
            {
                var path = "../NamesAndScores.xlsx";
                // Prolly there would be some provider issues
                excelConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'";

                excelConnection.Open();
                var sheetName = GetSheetName(excelConnection);
                var excelCommand = GetOleDbCommand(sheetName, excelConnection);

                using (var oleDbDataAdapter = new OleDbDataAdapter(excelCommand))
                {
                    var dataSet = new DataSet();
                    oleDbDataAdapter.Fill(dataSet);

                    using (var reader = dataSet.CreateDataReader())
                    {
                        while (reader.Read())
                        {
                            var fullName = reader["Name"];
                            var score = reader["Score"];

                            Console.WriteLine(fullName + " -> " + score);
                        }
                    }
                }
            }
        }

        private static string GetSheetName(OleDbConnection oleDbConnection)
        {
            var excelSchema = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            var sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();
            return sheetName;
        }

        private static OleDbCommand GetOleDbCommand(string sheetName, OleDbConnection excelConnection)
        {
            var oleDbCommand = new OleDbCommand(@"SELECT *
                                                           FROM [" + sheetName + "]", excelConnection);
            return oleDbCommand;
        }
    }
}
