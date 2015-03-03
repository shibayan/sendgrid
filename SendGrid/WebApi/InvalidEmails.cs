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

        public Task<InvalidEmailsResult[]> GetAsync(object parameters = null)
        {
            return GetAsync<InvalidEmailsResult[]>("get", parameters);
        }

        public Task DeleteAsync(string email)
        {
            return PostAsync("delete", new { email });
        }

        public Task<int> CountAsync()
        {
            return GetAsync<int>("count");
        }
    }
}
