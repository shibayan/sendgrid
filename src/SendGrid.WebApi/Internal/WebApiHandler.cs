using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace SendGrid.WebApi.Internal
{
    internal class WebApiHandler : DelegatingHandler
    {
        internal WebApiHandler(SendGridAccount account)
            : base(new HttpClientHandler())
        {
            _account = account;
        }

        private readonly SendGridAccount _account;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _account.ApiKey);

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
