using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class SpamReports : WebApiBase
    {
        public SpamReports(SendGridAccount account)
            : base(account)
        {
        }
    }
}
