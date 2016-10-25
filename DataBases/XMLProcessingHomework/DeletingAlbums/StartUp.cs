namespace DeletingAlbums
{
    using System;
    using System.Xml;

    public class StartUp
    {
        private const double PriceGivenByDescription = 20.0;

        private static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");
            var root = doc.DocumentElement;

            DeleteAlbumsByGivenPrice(root, PriceGivenByDescription);
            doc.Save("../../updatedCatalogue.xml");

            Console.WriteLine("Updated Catalogue after Delleting Albums by given Price is at this Console App folder(DeletingAlbums) " +
                              "named as updatedCatalogue.xml!!!");
        }

        private static void DeleteAlbumsByGivenPrice(XmlElement root, double conditionalPrice)
        {
            var childNodes = root.ChildNodes;

            for (var alb = childNodes.Count - 1; alb >= 0; alb--)
            {
                var album = childNodes[alb];

                var priceFromXml = album["price"].InnerText;
                var price = double.Parse(priceFromXml);

                if (price > conditionalPrice)
                {
                    root.RemoveChild(album);
                }
            }
        }
    }
}
