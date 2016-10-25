namespace AlbumsLinqQuery
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class StartUp
    {
        private static void Main()
        {
            var doc = XDocument.Load("../../../catalogue.xml");

            var albumNames = from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2011
                select album.Element("price").Value;

            Console.WriteLine("Album prices for albums released before 2011!(Using LinqQuery)");
            Console.WriteLine(string.Join(", ", albumNames));
        }
    }
}
