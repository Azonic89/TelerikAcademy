namespace JSONProcessing.Entities
{
    using Newtonsoft.Json;

    public class LinkRelHref
    {
        [JsonProperty("@rel")]
        public string Rel { get; set; }

        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}
