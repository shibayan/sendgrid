using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.MarketingEmailsApi
{
    public class Lists : MarketingEmailsApiBase
    {
        internal Lists(SendGridAccount account)
            : base(account, "lists")
        {
        }

        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task EditAsync()
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
