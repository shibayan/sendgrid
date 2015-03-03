using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class Unsubscribes : WebApiBase
    {
        internal Unsubscribes(SendGridAccount account)
            : base(account, "unsubscribes")
        {
        }

        public Task<object> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync()
        {
            throw new NotImplementedException();
        }
    }
}
