using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class ParseWebhook : WebApiBase
    {
        internal ParseWebhook(SendGridAccount account)
            : base(account, "parse")
        {
        }

        public Task<object> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task SetAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
