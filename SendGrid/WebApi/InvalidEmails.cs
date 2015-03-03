using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class InvalidEmails : WebApiBase
    {
        internal InvalidEmails(SendGridAccount account)
            : base(account, "invalidemails")
        {
        }

        public Task<object> GetAsync(object parameters = null)
        {
            return GetAsync<object>("get", parameters);
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
