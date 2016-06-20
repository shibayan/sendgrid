using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class SpamReports : WebApiBase
    {
        public SpamReports(Account account)
            : base(account)
        {
        }
    }
}
