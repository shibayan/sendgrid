using System.Linq;
using System.Net.Http;

namespace SendGrid.Internal
{
    public abstract class ParameterBase
    {
        protected virtual bool UseMultipart { get { return false; } }

        internal QueryStringCollection ToQueryString()
        {
            var result = new QueryStringCollection();

            foreach (var property in GetType().GetProperties())
            {
                var value = property.GetValue(this);

                if (value != null)
                {
                    result.Add(ToSnakeCase(property.Name), value.ToString());
                }
            }

            return result;
        }

        internal HttpContent ToHttpContent()
        {
            if (!UseMultipart)
            {
                return new FormUrlEncodedContent(ToQueryString());
            }

            var result = new MultipartFormDataContent();

            foreach (var property in GetType().GetProperties())
            {
                var value = property.GetValue(this);

                if (value == null)
                {
                    continue;
                }

                result.Add(new StringContent(value.ToString()), ToSnakeCase(property.Name));
            }

            return result;
        }

        private static string ToSnakeCase(string input)
        {
            return string.Concat(input.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}
