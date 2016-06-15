using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class Alerts : WebApiBase
    {
        public Alerts(SendGridAccount account)
            : base(account)
        {
        }
    }
}
