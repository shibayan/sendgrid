using System.Threading.Tasks;

namespace SendGrid.Internal
{
    public abstract class WebApiBase : ApiBase
    {
        protected WebApiBase(SendGridAccount account, string module)
            : base(account)
        {
            _module = module;
        }

        private readonly string _module;

        private const string Endpoint = "https://api.sendgrid.com/api/{0}.{1}.json";

        protected Task GetAsync(string action, object parameters = null)
        {
            return GetAsyncCore(FormatRequestUri(action, parameters));
        }

        protected Task<TResult> GetAsync<TResult>(string action, object parameters = null)
        {
            return GetAsyncCore<TResult>(FormatRequestUri(action, parameters));
        }

        protected Task PostAsync(string action, object parameters)
        {
            return PostAsyncCore(FormatRequestUri(action), null);
        }

        protected Task<TResult> PostAsync<TResult>(string action, object parameters)
        {
            return PostAsyncCore<TResult>(FormatRequestUri(action), null);
        }

        private string FormatRequestUri(string action, object parameters = null)
        {
            var url = string.Format(Endpoint, _module, action);

            if (parameters != null)
            {
                url += "?" + new QueryStringCollection(parameters);
            }

            return url;
        }
    }
}
