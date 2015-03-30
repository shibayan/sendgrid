using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.MarketingEmailsApi
{
    public class Recipients : MarketingEmailsApiBase
    {
        internal Recipients(SendGridAccount account)
            : base(account, "recipients")
        {
        }

        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
