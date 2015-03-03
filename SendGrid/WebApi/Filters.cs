using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class Filters : WebApiBase
    {
        internal Filters(SendGridAccount account)
            : base(account, "filters")
        {
        }
    }
}
