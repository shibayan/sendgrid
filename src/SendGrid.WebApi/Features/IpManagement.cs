using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class IpManagement : WebApiBase
    {
        internal IpManagement(SendGridAccount account)
            : base(account)
        {
        }
    }
}
