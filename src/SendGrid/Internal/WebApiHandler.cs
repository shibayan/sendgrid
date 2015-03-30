using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SendGrid.Internal
{
    internal class WebApiHandler : DelegatingHandler
    {
        internal WebApiHandler(SendGridAccount account, bool useV3)
            : base(new HttpClientHandler())
        {
            _account = account;
            _useV3 = useV3;
        }

        private readonly SendGridAccount _account;
        private readonly bool _useV3;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (_useV3)
            {
                var parameter = Convert.ToBase64String(Encoding.ASCII.GetBytes(_account.ApiUser + ":" + _account.ApiKey));

                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", parameter);
            }
            else
            {
                if (request.Method == HttpMethod.Get)
                {
                    var parameter = string.Format("api_user={0}&api_key={1}", _account.ApiUser, _account.ApiKey);

                    var uriBuilder = new UriBuilder(request.RequestUri);

                    if (string.IsNullOrEmpty(uriBuilder.Query))
                    {
                        uriBuilder.Query = parameter;
                    }
                    else
                    {
                        uriBuilder.Query = uriBuilder.Query.TrimStart('?') + "&" + parameter;
                    }

                    request.RequestUri = uriBuilder.Uri;
                }
                else
                {
                    var formUrlEncodedContent = request.Content as FormUrlEncodedContent;
                    var multipartFormDataContent = request.Content as MultipartFormDataContent;

                    if (formUrlEncodedContent != null)
                    {
                        var queryString = await formUrlEncodedContent.ReadAsStringAsync().ConfigureAwait(false);

                        var data = new QueryStringCollection(queryString)
                        {
                            new KeyValuePair<string, string>("api_user", _account.ApiUser),
                            new KeyValuePair<string, string>("api_key", _account.ApiKey)
                        };

                        request.Content = new FormUrlEncodedContent(data);
                    }
                    else if (multipartFormDataContent != null)
                    {
                        multipartFormDataContent.Add(new StringContent("api_user"), _account.ApiUser);
                        multipartFormDataContent.Add(new StringContent("api_key"), _account.ApiKey);
                    }
                }
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
