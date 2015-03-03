using System;

using Newtonsoft.Json;

namespace SendGrid.WebApi.Models
{
    public class UnsubscribesResult
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }
    }
}
