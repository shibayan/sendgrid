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

        public Task<SpamReportsResult[]> GetAsync(object parameters = null)
        {
            return GetAsync<SpamReportsResult[]>("get", parameters);
        }

        public Task DeleteAsync()
        {
            return PostAsync("delete", null);
        }

        public Task<int> CountAsync()
        {
            return GetAsync<int>("count");
        }
    }
}
