using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.MarketingEmailsApi.Models;

namespace SendGrid.MarketingEmailsApi
{
    public class Emails : MarketingEmailsApiBase
    {
        internal Emails(SendGridAccount account)
            : base(account, "lists", "email")
        {
        }

        public Task AddAsync(AddEmailsParameter parameter)
        {
            return PostAsync("add", parameter);
        }

        public Task GetAsync(GetEmailsParameter parameter)
        {
            return GetAsync("get", parameter);
        }

        public Task CountAsync(CountEmailsParameter parameter)
        {
            return GetAsync("count", parameter);
        }

        public Task DeleteAsync(DeleteEmailsParameter parameter)
        {
            return PostAsync("delete", parameter);
        }
    }
}
