namespace JSONProcessing.Entities
{
    using Newtonsoft.Json;

    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public LinkRelHref Link { get; set; }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }
    }
}
