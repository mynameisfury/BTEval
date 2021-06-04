namespace BoomTownEval.Models
{
    public class LicenseBase
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("key")]
        public Key Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name")]
        public LicenseName Name { get; set; }

        [JsonProperty("spdx_id")]
        public string SpdxId { get; set; }

        [JsonProperty("spdx_id")]
        public SpdxId SpdxId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("node_id")]
        public LicenseNodeId NodeId { get; set; }
    }
}