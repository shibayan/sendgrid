using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class ParseWebhook : WebApiBase
    {
        internal ParseWebhook(SendGridAccount account)
            : base(account, "parse")
        {
        }

        public async Task<GetParseWebhookResult[]> GetAsync()
        {
            return (await GetAsync<GetParseWebhookResultList>("get", new EmptyParameter())).Parse;
        }

        public Task SetAsync(SetParseWebhookParameter parameters)
        {
            return PostAsync("set", parameters);
        }

        public Task DeleteAsync(DeleteParseWebhookParameter parameters)
        {
            return PostAsync("delete", parameters);
        }
    }
}
