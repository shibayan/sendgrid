using Newtonsoft.Json;

namespace SendGrid.WebApiV3.Models
{
    public class GetEnforcedTlsResult
    {
        [JsonProperty("require_tls")]
        public bool RequireTls { get; set; }

        [JsonProperty("require_valid_cert")]
        public bool RequireValidCert { get; set; }
    }
}
