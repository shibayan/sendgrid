using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class SuppressionManagementFeature : WebApiBase
    {
        internal SuppressionManagementFeature(Account account)
            : base(account)
        {
        }
    }
}
