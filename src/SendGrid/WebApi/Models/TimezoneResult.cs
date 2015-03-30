using Newtonsoft.Json;

namespace SendGrid.WebApi.Models
{
    public class GetTimezoneResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }
}
