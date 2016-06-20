using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class InvalidEmailsFeature : WebApiBase
    {
        public InvalidEmailsFeature(Account account)
            : base(account)
        {
        }
    }
}
