using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.MarketingEmailsApi
{
    public class Variations : MarketingEmailsApiBase
    {
        internal Variations(SendGridAccount account)
            : base(account, "variations")
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

        public Task CancelAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task PickWinnerAsync()
        {
            throw new NotImplementedException();
        }

        public Task ScheduleAsync()
        {
            throw new NotImplementedException();
        }
    }
}
