using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class Credentials : WebApiBase
    {
        internal Credentials(SendGridAccount account)
            : base(account, "credentials")
        {
        }

        public Task<GetCredentialsResult[]> GetAsync(GetCredentialsParameter parameter)
        {
            return GetAsync<GetCredentialsResult[]>("get", parameter);
        }

        public Task AddAsync(AddCredentialsParameter parameter)
        {
            return PostAsync("add", parameter);
        }

        public Task EditAsync(EditCredentialsParameter parameter)
        {
            return PostAsync("edit", parameter);
        }

        public Task DeleteAsync(DeleteCredentialsParameter parameter)
        {
            return PostAsync("delete", parameter);
        }
    }
}
