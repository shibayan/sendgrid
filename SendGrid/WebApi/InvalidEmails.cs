using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class InvalidEmails : WebApiBase
    {
        internal InvalidEmails(SendGridAccount account)
            : base(account, "invalidemails")
        {
        }

        public Task<GetInvalidEmailsResult[]> GetAsync(GetInvalidEmailsParameter parameters)
        {
            return GetAsync<GetInvalidEmailsResult[]>("get", parameters);
        }

        public Task DeleteAsync(DeleteInvalidEmailsParameter parameters)
        {
            return PostAsync("delete", parameters);
        }

        public async Task<int> CountAsync(CountInvalidEmailsParameter parameters)
        {
            return (await GetAsync<CountInvalidEmailsResult>("count", parameters)).Count;
        }
    }
}
