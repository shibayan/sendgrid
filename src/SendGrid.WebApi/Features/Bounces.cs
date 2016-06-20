using System.Threading.Tasks;

using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class Bounces : WebApiBase
    {
        public Bounces(Account account)
            : base(account)
        {
        }

        public Task GetAsync()
        {
            return GetAsyncCore("suppression/bounces");
        }

        public Task GetAsync(string email)
        {
            return GetAsyncCore($"suppression/bounces/{email}");
        }

        public Task DeleteAsync()
        {
            return DeleteAsyncCore("suppression/bounces");
        }

        public Task DeleteAsync(string email)
        {
            return DeleteAsyncCore($"suppression/bounces/{email}");
        }
    }
}
