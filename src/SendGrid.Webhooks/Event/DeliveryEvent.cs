using Newtonsoft.Json;

namespace SendGrid.Webhooks.Event
{
    public class DeliveryEvent : EventBase
    {
        [JsonProperty("smtp-id")]
        public string SmtpId { get; set; }
    }
}
