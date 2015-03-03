using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace SendGrid.Internal
{
    public abstract class ApiBase
    {
        internal ApiBase(SendGridAccount account)
            : this(account, false)
        {
        }

        internal ApiBase(SendGridAccount account, bool useV3)
        {
            _account = account;
            _useV3 = useV3;
        }

        private readonly SendGridAccount _account;
        private readonly bool _useV3;

        protected Task GetAsyncCore(string requestUri)
        {
            return GetAsyncCore<object>(requestUri);
        }

        protected Task<TResult> GetAsyncCore<TResult>(string requestUri)
        {
            return ExecuteAsync<TResult>(x => x.GetAsync(requestUri));
        }

        protected Task PostAsyncCore(string requestUri, HttpContent content)
        {
            return PostAsyncCore<object>(requestUri, content);
        }

        protected Task<TResult> PostAsyncCore<TResult>(string requestUri, HttpContent content)
        {
            return ExecuteAsync<TResult>(x => x.PostAsync(requestUri, content));
        }

        protected Task PutAsyncCore(string requestUri, HttpContent content)
        {
            return PutAsyncCore<object>(requestUri, content);
        }

        protected Task<TResult> PutAsyncCore<TResult>(string requestUri, HttpContent content)
        {
            return ExecuteAsync<TResult>(x => x.PutAsync(requestUri, content));
        }

        protected Task DeleteAsyncCore(string requestUri)
        {
            return DeleteAsyncCore<object>(requestUri);
        }

        protected Task<TResult> DeleteAsyncCore<TResult>(string requestUri)
        {
            return ExecuteAsync<TResult>(x => x.DeleteAsync(requestUri));
        }

        private async Task<TResult> ExecuteAsync<TResult>(Func<HttpClient, Task<HttpResponseMessage>> func)
        {
            var client = new HttpClient(new WebApiHandler(_account, _useV3));

            var response = await func(client).ConfigureAwait(false);

            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                throw new SendGridRequestException(body);
            }

            return JsonConvert.DeserializeObject<TResult>(body);
        }
    }
}
