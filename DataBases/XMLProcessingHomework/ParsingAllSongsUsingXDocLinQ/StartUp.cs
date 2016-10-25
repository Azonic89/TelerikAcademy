namespace ParsingAllSongsUsingXDocLinQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class StartUp
    {
        private static void Main()
        {
            var doc = XDocument.Load("../../../catalogue.xml");
            var albums = doc.Element("catalogue").Elements("album");

            var titles = from title in albums.Descendants("title") select title.Value;

            Console.WriteLine("--------All song titles in the Catalogue(Parse using XDocument and LINQ)!--------");
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
