using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class ApiKeysFeature : WebApiBase
    {
        public ApiKeysFeature(Account account)
            : base(account)
        {
        }
    }
}
