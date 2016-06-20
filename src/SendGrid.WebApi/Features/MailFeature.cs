using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class MailFeature : WebApiBase
    {
        public MailFeature(Account account)
            : base(account)
        {
        }
    }
}
