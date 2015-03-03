using System.Web;
using System.Web.Helpers;

using Newtonsoft.Json;

namespace SendGrid.Webhooks.Internal
{
    public static class HttpRequestExtension
    {
        public static string AsString(this HttpRequestBase request, string key)
        {
            return request.Unvalidated(key);
        }

        public static string[] AsStringArray(this HttpRequestBase request, string key, params char[] separator)
        {
            return (request.Unvalidated(key) ?? "").Split(separator);
        }

        public static double AsInt(this HttpRequestBase request, string key)
        {
            int result;

            return int.TryParse(request.Unvalidated(key), out result) ? result : 0;
        }

        public static double AsDouble(this HttpRequestBase request, string key)
        {
            double result;

            return double.TryParse(request.Unvalidated(key), out result) ? result : double.NaN;
        }

        public static dynamic AsJson(this HttpRequestBase request, string key)
        {
            var result = request.Unvalidated(key);

            if (string.IsNullOrEmpty(result))
            {
                return null;
            }

            return JsonConvert.DeserializeObject(result);
        }

        public static TResult AsJson<TResult>(this HttpRequestBase request, string key)
        {
            var result = request.Unvalidated(key);

            if (string.IsNullOrEmpty(result))
            {
                return default(TResult);
            }

            return JsonConvert.DeserializeObject<TResult>(result);
        }
    }
}