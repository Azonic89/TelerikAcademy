namespace ParsingAllArtistsUsingDomParser
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class StartUp
    {
        private static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");
            var root = doc.DocumentElement;

            foreach (var paired in GetArtists(root))
            {
                Console.WriteLine($"Artist: {paired.Key} - Albums Count in the Catalogue: {paired.Value}");
            }
        }

        private static Dictionary<string, int> GetArtists(XmlElement root)
        {
            var artists = root.GetElementsByTagName("artist");
            var artistAndAlbums = new Dictionary<string, int>();

            foreach (XmlElement artist in artists)
            {
                var artistName = artist.InnerText;

                if (artistAndAlbums.ContainsKey(artistName))
                {
                    artistAndAlbums[artistName] += 1;
                }
                else
                {
                    artistAndAlbums.Add(artistName, 1);
                }
            }

            return artistAndAlbums;
        }
    }
}
