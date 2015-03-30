using System;

using Newtonsoft.Json;

namespace SendGrid.WebApi.Models
{
    public class GetInvalidEmailsResult
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CountInvalidEmailsResult
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
