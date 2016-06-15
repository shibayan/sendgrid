using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class SuppressionManagement : WebApiBase
    {
        internal SuppressionManagement(SendGridAccount account)
            : base(account)
        {
        }
    }
}
