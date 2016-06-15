using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class AdvancedSuppressionManager : WebApiBase
    {
        internal AdvancedSuppressionManager(SendGridAccount account)
            : base(account)
        {
        }
    }
}
