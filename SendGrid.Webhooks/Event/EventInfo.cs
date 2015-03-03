using System.Collections.Generic;
using System.Web.Mvc;

namespace SendGrid.Webhooks.Event
{
    [ModelBinder(typeof(EventModelBinder))]
    public class EventInfo
    {
        public IList<EventBase> Data { get; set; }
    }
}
