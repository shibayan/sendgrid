using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.MarketingEmailsApi
{
    public class Emails : MarketingEmailsApiBase
    {
        protected Emails(SendGridAccount account)
            : base(account, "lists", "email")
        {
        }

        public Task AddAsync()
        {
            return PostAsync("add", new EmptyParameter());
        }

        public Task GetAsync()
        {
            return GetAsync("get", new EmptyParameter());
        }

        public Task CountAsync()
        {
            return GetAsync("count", new EmptyParameter());
        }

        public Task DeleteAsync()
        {
            return PostAsync("delete", new EmptyParameter());
        }
    }
}
