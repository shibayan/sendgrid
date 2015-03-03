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

        public Task<BouncesResult[]> GetAsync(object parameters = null)
        {
            return GetAsync<BouncesResult[]>("get", parameters);
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
