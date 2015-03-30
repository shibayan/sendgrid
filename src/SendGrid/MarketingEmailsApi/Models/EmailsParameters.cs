using SendGrid.Internal;

namespace SendGrid.MarketingEmailsApi.Models
{
    public class AddEmailsParameter : ParameterBase
    {
        public string List { get; set; }

        public string Data { get; set; }
    }

    public class GetEmailsParameter : ParameterBase
    {
        public string List { get; set; }

        public string Email { get; set; }

        public bool Unsubscribed { get; set; }
    }

    public class CountEmailsParameter : ParameterBase
    {
        public string List { get; set; }
    }

    public class DeleteEmailsParameter : ParameterBase
    {
        public string List { get; set; }

        public string[] Emails { get; set; }
    }
}
