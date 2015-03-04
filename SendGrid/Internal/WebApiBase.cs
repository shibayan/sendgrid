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

        protected Task GetAsync(string action, ParameterBase parameter = null)
        {
            return GetAsyncCore(FormatRequestUri(action), parameter);
        }

        protected Task<TResult> GetAsync<TResult>(string action, ParameterBase parameter = null)
        {
            return GetAsyncCore<TResult>(FormatRequestUri(action), parameter);
        }

        protected Task PostAsync(string action, ParameterBase parameter)
        {
            return PostAsyncCore(FormatRequestUri(action), parameter);
        }

        protected Task<TResult> PostAsync<TResult>(string action, ParameterBase parameter)
        {
            return PostAsyncCore<TResult>(FormatRequestUri(action), parameter);
        }

        private string FormatRequestUri(string action)
        {
            return string.Format(Endpoint, _module, action);
        }
    }
}
