using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApi.Models;

namespace SendGrid.WebApi
{
    public class Mail : WebApiBase
    {
        internal Mail(SendGridAccount account)
            : base(account, "mail")
        {
        }

        public Task SendAsync(SendMailParameter parameters)
        {
            return PostAsync("send", parameters);
        }
    }
}
