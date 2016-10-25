namespace ExtractAlbumXMLReaderWriter
{
    using System;
    using System.Text;
    using System.Xml;

    public class StartUp
    {
        private static void Main()
        {
            Console.WriteLine("New albums.xml is in this Console App folr(ExtractAlbumXMLReaderWriter)!");
            using (var writer = new XmlTextWriter("../../albums.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.IndentChar = ' ';
                
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (var reader = XmlReader.Create("../../../catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                writer.WriteElementString("name", reader.ReadElementString());
                            }
                            else if (reader.Name == "artist")
                            {
                                writer.WriteElementString("artist", reader.ReadElementString());
                                writer.WriteEndElement();
                            }
                        }
                    }                  
                }

                writer.WriteEndDocument();
            }
        }
    }
}
