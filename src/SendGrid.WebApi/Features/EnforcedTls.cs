using System.Threading.Tasks;

using SendGrid.WebApi.Features.Results;
using SendGrid.WebApi.Internal;

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
