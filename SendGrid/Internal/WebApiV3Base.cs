using System.Threading.Tasks;

namespace SendGrid.Internal
{
    public class WebApiV3Base : ApiBase
    {
        public WebApiV3Base(SendGridAccount account)
            : base(account, true)
        {
        }

        private const string Endpoint = "https://api.sendgrid.com/v3/{0}";

        protected Task GetAsync(string path, object parameters = null)
        {
            return GetAsyncCore(FormatRequestUri(path), null);
        }

        protected Task<TResult> GetAsync<TResult>(string path, object parameters = null)
        {
            return GetAsyncCore<TResult>(FormatRequestUri(path), null);
        }

        protected Task PostAsync(string path, object parameters)
        {
            return PostAsyncCore(FormatRequestUri(path), null);
        }

        protected Task<TResult> PostAsync<TResult>(string path, object parameters)
        {
            return PostAsyncCore<TResult>(FormatRequestUri(path), null);
        }

        private string FormatRequestUri(string path)
        {
            return string.Format(Endpoint, path.TrimStart('/'));
        }
    }
}
