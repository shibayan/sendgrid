using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class Timezone : WebApiBase
    {
        internal Timezone(SendGridAccount account)
            : base(account, "timezone")
        {
        }

        public Task<GetTimezoneResult> GetAsync()
        {
            return GetAsync<GetTimezoneResult>("get", new EmptyParameter());
        }

        public Task EditAsync(EditTimezoneParameter parameter)
        {
            return PostAsync("edit", parameter);
        }

        public Task<GetTimezoneResult[]> ListAsync(ListTimezoneParameter parameter)
        {
            return GetAsync<GetTimezoneResult[]>("list", parameter);
        }
    }
}
