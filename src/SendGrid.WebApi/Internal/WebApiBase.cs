using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace SendGrid.WebApi.Internal
{
    public class WebApiBase
    {
        public WebApiBase(SendGridAccount account)
        {
            _account = account;
        }

        private const string Endpoint = "https://api.sendgrid.com/v3/{0}";

        private readonly SendGridAccount _account;

        protected Task GetAsync(string path, object parameters = null)
        {
            return GetAsync<object>(path, parameters);
        }

        protected Task<TResult> GetAsync<TResult>(string path, object parameters = null)
        {
            return ExecuteAsync<TResult>(x => x.GetAsync(FormatRequestUri(path)));
        }

        protected Task PostAsync(string path, object parameters)
        {
            return PostAsync<object>(path, parameters);
        }

        protected Task<TResult> PostAsync<TResult>(string path, object parameters)
        {
            return ExecuteAsync<TResult>(x => x.PostAsync(FormatRequestUri(path), new JsonContent(parameters)));
        }

        protected Task DeleteAsync(string path, object parameters = null)
        {
            return DeleteAsync<object>(path, parameters);
        }

        protected Task<TResult> DeleteAsync<TResult>(string path, object parameters = null)
        {
            return ExecuteAsync<TResult>(x => x.DeleteAsync(FormatRequestUri(path)));
        }

        protected Task PatchAsync(string path, object parameters)
        {
            return PatchAsync<object>(path, parameters);
        }

        protected Task<TResult> PatchAsync<TResult>(string path, object parameters)
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
                throw new SendGridRequestException();
            }

            return JsonConvert.DeserializeObject<TResult>(body);
        }
    }
}
