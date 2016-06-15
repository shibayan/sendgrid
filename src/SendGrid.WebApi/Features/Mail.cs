using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class Mail : WebApiBase
    {
        public Mail(SendGridAccount account)
            : base(account)
        {
        }
    }
}
