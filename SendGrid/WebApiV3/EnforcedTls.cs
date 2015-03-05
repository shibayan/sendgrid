using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.WebApiV3.Models;

namespace SendGrid.WebApiV3
{
    public class EnforcedTls : WebApiV3Base
    {
        public EnforcedTls(SendGridAccount account)
            : base(account)
        {
        }

        public Task<GetEnforcedTlsResult> GetAsync()
        {
            return GetAsync<GetEnforcedTlsResult>("user/settings/enforced_tls", new EmptyParameter());
        }
    }
}
