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

        public Task<GetUnsubscribesResult[]> GetAsync(GetUnsubscribesParameter parameters)
        {
            return GetAsync<GetUnsubscribesResult[]>("get", parameters);
        }

        public Task DeleteAsync(DeleteUnsubscribesParameter parameters)
        {
            return PostAsync("delete", parameters);
        }

        public Task AddAsync(AddUnsubscribesParameter parameters)
        {
            return PostAsync("add", parameters);
        }
    }
}
