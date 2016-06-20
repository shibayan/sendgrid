using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class SpamReportsFeature : WebApiBase
    {
        public SpamReportsFeature(Account account)
            : base(account)
        {
        }
    }
}
