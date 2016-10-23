namespace JSONProcessing
{
    using System;
    using System.Text;

    using Entities;

    public class StartUp
    {
        private const string RssLink = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        private const string XmlPath = "videos.xml";
        private const string HtmlName = "index.html";

        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var jsonProccesor = new JsonProcessor();

            jsonProccesor.DownloadRss(RssLink, XmlPath);

            var xmlDoc = jsonProccesor.GetXml(XmlPath);
            var jsonObj = jsonProccesor.GetJsonJObject(xmlDoc);
            var titles = jsonProccesor.GetVideosTitles(jsonObj);
            jsonProccesor.PrintTitles(titles);

            var videos = jsonProccesor.GetVideos(jsonObj);
            var html = jsonProccesor.GetHtmlAsString(videos);
            jsonProccesor.SaveHtml(html, HtmlName);
        }
    }
}
