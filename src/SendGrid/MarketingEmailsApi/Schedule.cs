using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.MarketingEmailsApi
{
    public class Schedule : MarketingEmailsApiBase
    {
        internal Schedule(SendGridAccount account)
            : base(account, "schedule")
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
