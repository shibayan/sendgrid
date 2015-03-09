using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.MarketingEmailsApi
{
    public class Categories : MarketingEmailsApiBase
    {
        internal Categories(SendGridAccount account)
            : base(account, "categories")
        {
        }

        public Task CreateAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync()
        {
            throw new NotImplementedException();
        }

        public Task ListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
