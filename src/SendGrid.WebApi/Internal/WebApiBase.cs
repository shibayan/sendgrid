using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace SendGrid.WebApi.Internal
{
    public class WebApiBase
    {
        public WebApiBase(Account account)
        {
            _account = account;
        }

        private const string Endpoint = "https://api.sendgrid.com/v3/{0}";

        private readonly Account _account;

        protected Task GetAsyncCore(string path, object parameters = null)
        {
            return GetAsyncCore<object>(path, parameters);
        }

        protected Task<TResult> GetAsyncCore<TResult>(string path, object parameters = null)
        {
            return ExecuteAsync<TResult>(x => x.GetAsync(FormatRequestUri(path)));
        }

        protected Task PostAsyncCore(string path, object parameters)
        {
            return PostAsyncCore<object>(path, parameters);
        }

        protected Task<TResult> PostAsyncCore<TResult>(string path, object parameters)
        {
            return ExecuteAsync<TResult>(x => x.PostAsync(FormatRequestUri(path), new JsonContent(parameters)));
        }

        protected Task DeleteAsyncCore(string path, object parameters = null)
        {
            return DeleteAsyncCore<object>(path, parameters);
        }

        protected Task<TResult> DeleteAsyncCore<TResult>(string path, object parameters = null)
        {
            return ExecuteAsync<TResult>(x => x.DeleteAsync(FormatRequestUri(path)));
        }

        protected Task PatchAsyncCore(string path, object parameters)
        {
            return PatchAsyncCore<object>(path, parameters);
        }

        protected Task<TResult> PatchAsyncCore<TResult>(string path, object parameters)
        {
            return ExecuteAsync<TResult>(x => x.PatchAsync(FormatRequestUri(path), new JsonContent(parameters)));
        }

        private static string FormatRequestUri(string path)
        {
            return string.Format(Endpoint, path.TrimStart('/'));
        }

        private async Task<TResult> ExecuteAsync<TResult>(Func<HttpClient, Task<HttpResponseMessage>> requestExecutor)
        {
            var client = new HttpClient(new WebApiHandler(_account));

            var response = await requestExecutor(client).ConfigureAwait(false);

            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                throw new RequestException();
            }

            return JsonConvert.DeserializeObject<TResult>(body);
        }
    }
}
