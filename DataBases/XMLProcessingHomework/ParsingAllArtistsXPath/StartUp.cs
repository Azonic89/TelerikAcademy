namespace ParsingAllArtistsXPath
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

            foreach (var paired in GetArtists(doc))
            {
                Console.WriteLine($"Artist: {paired.Key} - Albums Count in the Catalogue: {paired.Value}");
            }
        }

        private static Dictionary<string, int> GetArtists(XmlDocument root)
        {
            var artists = root.SelectNodes("/catalogue/album/artist");
            var artistsAndAlbums = new Dictionary<string, int>();

            foreach (XmlNode artist in artists)
            {
                var artistName = artist.InnerText;

                if (artistsAndAlbums.ContainsKey(artistName))
                {
                    artistsAndAlbums[artistName] += 1;
                }
                else
                {
                    artistsAndAlbums.Add(artistName, 1);
                }
            }

            return artistsAndAlbums;
        }
    }
}
