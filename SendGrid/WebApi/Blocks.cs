using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class Blocks : WebApiBase
    {
        internal Blocks(SendGridAccount account)
            : base(account, "blocks")
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
