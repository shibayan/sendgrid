namespace SendGrid.Webhooks.Event
{
    public enum EventType
    {
        Processed,
        Deferred,
        Delivered,
        Open,
        Click,
        Bounce,
        Drop,
        SpamReport,
        Unsubscribe
    }
}
