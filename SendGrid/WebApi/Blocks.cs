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

        public Task<GetBlocksResult[]> GetAsync(GetBlocksParameter parameters)
        {
            return GetAsync<GetBlocksResult[]>("get", parameters);
        }

        public Task DeleteAsync(DeleteBlocksParameter parameters)
        {
            return PostAsync("delete", parameters);
        }

        public async Task<int> CountAsync(CountBlocksParameter parameters)
        {
            return (await GetAsync<CountBlocksResult>("count", parameters)).Count;
        }
    }
}
