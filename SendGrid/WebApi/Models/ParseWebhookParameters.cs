using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public class SetParseWebhookParameter : ParameterBase
    {
        public string Hostname { get; set; }

        public string Url { get; set; }

        public bool? SpamCheck { get; set; }
    }

    public class DeleteParseWebhookParameter : ParameterBase
    {
        public string Hostname { get; set; }
    }
}
