using System;

using Newtonsoft.Json;

namespace SendGrid.WebApi.Models
{
    public class GetSpamReportsResult
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }
    }

    public class CountSpamReportsResult
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
