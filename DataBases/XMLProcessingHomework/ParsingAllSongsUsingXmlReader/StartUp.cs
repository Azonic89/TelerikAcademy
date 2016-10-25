namespace ParsingAllSongsUsingXmlReader
{
    using System;
    using System.Xml;

    public class StartUp
    {
        private static void Main()
        {
            using (XmlReader reader = new XmlTextReader("../../../catalogue.xml"))
            {
                Console.WriteLine("--------All song titles in the Catalogue(Parse using XmlReader)!--------");

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {                       
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
