using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class SpamReports : WebApiBase
    {
        internal SpamReports(SendGridAccount account)
            : base(account, "spamreports")
        {
        }

        public Task<GetSpamReportsResult[]> GetAsync(GetSpamReportsParameter parameters)
        {
            return GetAsync<GetSpamReportsResult[]>("get", parameters);
        }

        public Task DeleteAsync(DeleteSpamReportsParameter parameters)
        {
            return PostAsync("delete", parameters);
        }

        public async Task<int> CountAsync(CountSpamReportsParameter parameters)
        {
            return (await GetAsync<CountSpamReportsResult>("count", parameters)).Count;
        }
    }
}
