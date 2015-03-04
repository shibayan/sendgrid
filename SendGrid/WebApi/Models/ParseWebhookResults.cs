using Newtonsoft.Json;

namespace SendGrid.WebApi.Models
{
    public class GetParseWebhookResult
    {
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("spam_check")]
        public bool SpamCheck { get; set; }
    }

    public class GetParseWebhookResultList
    {
        [JsonProperty("parse")]
        public GetParseWebhookResult[] Parse { get; set; }
    }
}
