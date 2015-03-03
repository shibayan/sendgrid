using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class Unsubscribes : WebApiBase
    {
        internal Unsubscribes(SendGridAccount account)
            : base(account, "unsubscribes")
        {
        }

        public Task<UnsubscribesResult[]> GetAsync(object parameters = null)
        {
            return GetAsync<UnsubscribesResult[]>("get", parameters);
        }

        public Task DeleteAsync(string email)
        {
            return PostAsync("delete", new { email });
        }

        public Task AddAsync(string email)
        {
            return PostAsync("add", new { email });
        }
    }
}
