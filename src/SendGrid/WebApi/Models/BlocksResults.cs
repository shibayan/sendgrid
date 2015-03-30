using System;

using Newtonsoft.Json;

namespace SendGrid.WebApi.Models
{
    public class GetBlocksResult
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CountBlocksResult
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
