namespace SendGrid.WebHooks.Event
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
