using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class Profile : WebApiBase
    {
        internal Profile(SendGridAccount account)
            : base(account, "profile")
        {
        }

        public Task<GetProfileResult[]> GetAsync()
        {
            return GetAsync<GetProfileResult[]>("get", new EmptyParameter());
        }

        public Task SetAsync(SetProfileParameter parameter)
        {
            return PostAsync("set", parameter);
        }

        public Task SetPasswordAsync(SetPasswordProfileParameter parameter)
        {
            return PostAsync("setPassword", parameter);
        }

        public Task SetUsernameAsync(SetUsernameProfileParameter parameter)
        {
            return PostAsync("setUsername", parameter);
        }

        public Task SetEmailAsync(SetEmailProfileParameter parameter)
        {
            return PostAsync("setEmail", parameter);
        }
    }
}
