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

        protected Task GetAsync(string path, ParameterBase parameters)
        {
            return GetAsyncCore(FormatRequestUri(path), parameters);
        }

        protected Task<TResult> GetAsync<TResult>(string path, ParameterBase parameters)
        {
            return GetAsyncCore<TResult>(FormatRequestUri(path), parameters);
        }

        protected Task PostAsync(string path, ParameterBase parameters)
        {
            return PostAsyncCore(FormatRequestUri(path), parameters);
        }

        protected Task<TResult> PostAsync<TResult>(string path, ParameterBase parameters)
        {
            return PostAsyncCore<TResult>(FormatRequestUri(path), parameters);
        }

        protected Task DeleteAsync(string path, ParameterBase parameters)
        {
            return DeleteAsyncCore(FormatRequestUri(path), parameters);
        }

        protected Task<TResult> DeleteAsync<TResult>(string path, ParameterBase parameters)
        {
            return DeleteAsyncCore<TResult>(FormatRequestUri(path), parameters);
        }

        protected Task PatchAsync(string path, ParameterBase parameters)
        {
            return PatchAsyncCore(FormatRequestUri(path), parameters);
        }

        protected Task<TResult> PatchAsync<TResult>(string path, ParameterBase parameters)
        {
            return PatchAsyncCore<TResult>(FormatRequestUri(path), parameters);
        }

        private string FormatRequestUri(string path)
        {
            return string.Format(Endpoint, path.TrimStart('/'));
        }
    }
}
