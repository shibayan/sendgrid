using Newtonsoft.Json;

namespace SendGrid.WebHooks.Event
{
    public class DeliveryEvent : EventBase
    {
        [JsonProperty("smtp-id")]
        public string SmtpId { get; set; }
    }
}
