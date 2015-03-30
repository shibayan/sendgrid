using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class Bounces : WebApiBase
    {
        internal Bounces(SendGridAccount account)
            : base(account, "bounces")
        {
        }

        public Task<GetBouncesResult[]> GetAsync(GetBouncesParameter parameters)
        {
            return GetAsync<GetBouncesResult[]>("get", parameters);
        }

        public Task DeleteAsync(DeleteBouncesParameter parameters)
        {
            return PostAsync("delete", parameters);
        }

        public async Task<int> CountAsync(CountBouncesParameter parameters)
        {
            return (await GetAsync<CountBouncesResult>("count", parameters)).Count;
        }
    }
}
