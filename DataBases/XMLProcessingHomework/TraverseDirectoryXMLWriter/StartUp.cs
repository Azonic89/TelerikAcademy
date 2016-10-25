namespace TraverseDirectoryXMLWriter
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public class StartUp
    {
        private static void Main()
        {
            using (var writer = new XmlTextWriter("../../directory.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.IndentChar = ' ';

                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                
                writer.WriteStartDocument();
                writer.WriteStartElement("Destop");
                TraverseDirectory(desktopPath, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("Newly formed directory.xml is at this Console App folder(TraverseDirectoryXMLWriter)!");
        }

        private static void TraverseDirectory(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                TraverseDirectory(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("ext", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}
