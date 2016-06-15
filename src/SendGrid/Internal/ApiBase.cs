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
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            _account = account;
            _useV3 = useV3;
        }

        private readonly SendGridAccount _account;
        private readonly bool _useV3;

        #region REST Methods

        protected Task GetAsyncCore(string requestUri, ParameterBase parameter)
        {
            return GetAsyncCore<object>(requestUri, parameter);
        }

        protected Task<TResult> GetAsyncCore<TResult>(string requestUri, ParameterBase parameter)
        {
            if (requestUri == null)
            {
                throw new ArgumentNullException(nameof(requestUri));
            }

            if (parameter == null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }

            return ExecuteAsync<TResult>(x => x.GetAsync(requestUri + parameter.ToQueryString()));
        }

        protected Task PostAsyncCore(string requestUri, ParameterBase parameter)
        {
            return PostAsyncCore<object>(requestUri, parameter);
        }

        protected Task<TResult> PostAsyncCore<TResult>(string requestUri, ParameterBase parameter)
        {
            if (requestUri == null)
            {
                throw new ArgumentNullException(nameof(requestUri));
            }

            if (parameter == null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }

            return ExecuteAsync<TResult>(x => x.PostAsync(requestUri, parameter.ToHttpContent()));
        }

        protected Task PutAsyncCore(string requestUri, ParameterBase parameter)
        {
            return PutAsyncCore<object>(requestUri, parameter);
        }

        protected Task<TResult> PutAsyncCore<TResult>(string requestUri, ParameterBase parameter)
        {
            if (requestUri == null)
            {
                throw new ArgumentNullException(nameof(requestUri));
            }

            if (parameter == null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }

            return ExecuteAsync<TResult>(x => x.PutAsync(requestUri, parameter.ToHttpContent()));
        }

        protected Task DeleteAsyncCore(string requestUri, ParameterBase parameter)
        {
            return DeleteAsyncCore<object>(requestUri, parameter);
        }

        protected Task<TResult> DeleteAsyncCore<TResult>(string requestUri, ParameterBase parameter)
        {
            if (requestUri == null)
            {
                throw new ArgumentNullException(nameof(requestUri));
            }

            if (parameter == null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }

            return ExecuteAsync<TResult>(x => x.DeleteAsync(requestUri + parameter.ToQueryString()));
        }

        protected Task PatchAsyncCore(string requestUri, ParameterBase parameter)
        {
            return PatchAsyncCore<object>(requestUri, parameter);
        }

        protected Task<TResult> PatchAsyncCore<TResult>(string requestUri, ParameterBase parameter)
        {
            if (requestUri == null)
            {
                throw new ArgumentNullException(nameof(requestUri));
            }

            if (parameter == null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }

            return ExecuteAsync<TResult>(x => x.PatchAsync(requestUri, parameter.ToHttpContent()));
        }

        #endregion

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
