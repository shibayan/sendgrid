using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class Profile : WebApiBase
    {
        internal Profile(SendGridAccount account)
            : base(account, "profile")
        {
        }

        public Task<object> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task SetAsync()
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordAsync()
        {
            throw new NotImplementedException();
        }

        public Task SetUsernameAsync()
        {
            throw new NotImplementedException();
        }

        public Task SetEmailAsync()
        {
            throw new NotImplementedException();
        }
    }
}
