using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class UsersFeature : WebApiBase
    {
        public UsersFeature(Account account)
            : base(account)
        {
        }
    }
}
