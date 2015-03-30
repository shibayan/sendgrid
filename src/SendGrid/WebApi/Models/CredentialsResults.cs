using Newtonsoft.Json;

namespace SendGrid.WebApi.Models
{
    public class GetCredentialsResult
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permissions")]
        public GetCredentialsPermissionResult Permissions { get; set; }
    }

    public class GetCredentialsPermissionResult
    {
        [JsonProperty("api")]
        public bool Api { get; set; }

        [JsonProperty("email")]
        public bool Email { get; set; }

        [JsonProperty("web")]
        public bool Web { get; set; }
    }
}
