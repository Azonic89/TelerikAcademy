namespace AlbumsXPathQuery
{
    using System;
    using System.Xml;

    public class StartUp
    {
        private static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");

            var xPathQuery = "/catalogue/album[year<2011]/price";

            var albumNames = doc.SelectNodes(xPathQuery);

            Console.WriteLine("Album prices for albums released before 2011!(Using XPathQuery)");
            foreach (XmlNode price in albumNames)
            {
                Console.WriteLine(price.InnerText);
            }
        }
    }
}
