namespace JSONProcessing.Entities
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JsonProcessor
    {
        public IEnumerable<Video> GetVideos(JObject json)
        {
            var videos = json["feed"]["entry"]
                .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));

            return videos;
        }

        public string GetHtmlAsString(IEnumerable<Video> videos)
        {
            var html = new StringBuilder();

            html.Append("<!DOCTYPE html><html><body>");
            foreach (var video in videos)
            {
                html.Append("<div style=\"float:left; width: 420px; height: 450px; padding:10px; " 
                    + "margin:5px; background-color:lightgreen; border-radius:8px\">" + 
                    "<iframe width=\"420\" height=\"345\" " + $"src=\"http://www.youtube.com/embed/{video.Id}?autoplay=0\" " 
                    + "frameborder=\"0\" allowfullscreen></iframe>" 
                    + $"<h3>{video.Title}</h3><a href=\"{video.Link.Href}\">Click this Link to be redirected to Youtube!</a></div>");
            }

            html.Append("</body></html>");

            return html.ToString();
        }
        public void DownloadRss(string url, string fileName)
        {
            var webClient = new WebClient {Encoding = Encoding.UTF8};
            webClient.DownloadFile(url, fileName);
        }

        public XmlDocument GetXml(string path)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            return xmlDoc;
        }

        public JObject GetJsonJObject(XmlDocument xmlDoc)
        {
            var json = JsonConvert.SerializeXmlNode(xmlDoc);
            var jsonObj = JObject.Parse(json);

            return jsonObj;
        }

        public IEnumerable<JToken> GetVideosTitles(JObject jsonObj)
        {
            return jsonObj["feed"]["entry"].Select(entry => entry["title"]);
        }

        public void PrintTitles(IEnumerable<JToken> titles)
        {
            Console.WriteLine(string.Join(Environment.NewLine, titles));
        }

        public void SaveHtml(string html, string htmlName)
        {
            using (var writer = new StreamWriter("../../" + htmlName, false, Encoding.UTF8))
            {
                writer.Write(html);
            }

            Console.WriteLine();
        }
    }
}
