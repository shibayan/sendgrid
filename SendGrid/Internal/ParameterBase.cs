using System.Net.Http;

namespace SendGrid.Internal
{
    public abstract class ParameterBase
    {
        protected virtual bool UseMultipart { get { return false; } }

        private string ToSnakeCase(string name)
        {
            return name.ToLower();
        }

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
    }
}
