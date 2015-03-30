namespace SendGrid.Webhooks.Event
{
    public class EngagementEvent : EventBase
    {
        public string UserAgent { get; set; }

        public string Ip { get; set; }

        public string[] Category { get; set; }
    }
}
