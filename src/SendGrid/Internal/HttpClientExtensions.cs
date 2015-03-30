using System.Net.Http;
using System.Threading.Tasks;

namespace SendGrid.Internal
{
    internal static class HttpClientExtensions
    {
        internal static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content)
        {
            var request = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri)
            {
                Content = content
            };

            return client.SendAsync(request);
        }
    }
}
