using System;
using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class Timezone : WebApiBase
    {
        internal Timezone(SendGridAccount account)
            : base(account, "timezone")
        {
        }

        public Task<object> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task EditAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> ListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
