using System.Collections.Generic;

using Newtonsoft.Json;

namespace SendGrid.WebHooks.Event
{
    public abstract class EventBase
    {
        public EventType Event { get; set; }

        public string Email { get; set; }

        [JsonIgnore]
        public IDictionary<string, string> UniqueArgs { get; set; }
    }
}
