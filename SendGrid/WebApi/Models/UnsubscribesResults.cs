using System;

using Newtonsoft.Json;

namespace SendGrid.WebApi.Models
{
    public class GetUnsubscribesResult
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }
    }
}
