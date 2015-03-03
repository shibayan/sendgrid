using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class Mail : WebApiBase
    {
        internal Mail(SendGridAccount account)
            : base(account, "mail")
        {
        }

        public Task SendAsync()
        {
            throw new NotImplementedException();
        }
    }
}
