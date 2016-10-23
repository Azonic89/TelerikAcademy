namespace TraverseDirectoryXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class StartUp
    {
        private static void Main()
        {
            var desktop = Traverse(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            desktop.Save("../../directory.xml");

            Console.WriteLine("Newly formed directory.xml is at this Console App folder(TraverseDirectoryXDocument)!");
        }

        private static XElement Traverse(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(
                    new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)), 
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}
