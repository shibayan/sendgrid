using System.Threading.Tasks;

using SendGrid.WebApi.Internal;
using SendGrid.WebApi.Results;

namespace SendGrid.WebApi.Features
{
    public class EnforcedTls : WebApiBase
    {
        public EnforcedTls(Account account)
            : base(account)
        {
        }

        public Task<GetEnforcedTlsResult> GetAsync()
        {
            return GetAsyncCore<GetEnforcedTlsResult>("user/settings/enforced_tls");
        }
    }
}
