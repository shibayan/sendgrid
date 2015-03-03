using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class Blocks : WebApiBase
    {
        internal Blocks(SendGridAccount account)
            : base(account, "blocks")
        {
        }

        public Task<BlocksResult[]> GetAsync(object parameters = null)
        {
            return GetAsync<BlocksResult[]>("get", parameters);
        }

        public Task DeleteAsync(string email)
        {
            return PostAsync("delete", new { email });
        }

        public Task<int> CountAsync(object parameters = null)
        {
            return GetAsync<int>("count");
        }
    }
}
