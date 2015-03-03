using System.Threading.Tasks;

using SendGrid.Internal;

namespace SendGrid.WebApi
{
    public class Bounces : WebApiBase
    {
        internal Bounces(SendGridAccount account)
            : base(account, "bounces")
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
