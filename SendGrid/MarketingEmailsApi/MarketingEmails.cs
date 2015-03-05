using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.MarketingEmailsApi
{
    public class MarketingEmails : MarketingEmailsApiBase
    {
        protected MarketingEmails(SendGridAccount account)
            : base(account)
        {
        }

        public Task AddAsync()
        {
            return PostAsync("add", new EmptyParameter());
        }

        public Task EditAsync()
        {
            return PostAsync("edit", new EmptyParameter());
        }

        public Task GetAsync()
        {
            return PostAsync("get", new EmptyParameter());
        }

        public Task ListAsync()
        {
            return PostAsync("list", new EmptyParameter());
        }

        public Task DeleteAsync()
        {
            return PostAsync("delete", new EmptyParameter());
        }
    }
}
