using System.Threading.Tasks;

namespace SendGrid.Internal
{
    public class MarketingEmailsApiBase : ApiBase
    {
        protected MarketingEmailsApiBase(SendGridAccount account, params string[] modules)
            : base(account)
        {
            _modules = modules;
        }

        private readonly string[] _modules;

        private const string Endpoint = "https://api.sendgrid.com/api/newsletter/{0}{1}.json";

        protected Task GetAsync(string action, ParameterBase parameter)
        {
            return GetAsyncCore(FormatRequestUri(action), parameter);
        }

        protected Task<TResult> GetAsync<TResult>(string action, ParameterBase parameter)
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
            return string.Format(Endpoint, string.Join("/", _modules), action);
        }
    }
}
