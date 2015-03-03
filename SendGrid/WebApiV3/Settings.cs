using SendGrid.Internal;

namespace SendGrid.WebApiV3
{
    public class Settings : WebApiV3Base
    {
        internal Settings(SendGridAccount account)
            : base(account)
        {
        }
    }
}
