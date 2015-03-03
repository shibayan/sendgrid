using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class MultipleCredentials : WebApiBase
    {
        internal MultipleCredentials(SendGridAccount account)
            : base(account, "credentials")
        {
        }

        public Task<object> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task EditAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
