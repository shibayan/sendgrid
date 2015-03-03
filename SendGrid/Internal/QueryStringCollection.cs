using System;
using System.Collections.Generic;
using System.Text;

namespace SendGrid.Internal
{
    internal class QueryStringCollection : List<KeyValuePair<string, string>>
    {
        internal QueryStringCollection(string queryString)
        {
            if (queryString == null)
            {
                throw new ArgumentNullException("queryString");
            }

            foreach (var item in queryString.TrimStart('?').Split('&'))
            {
                var pair = item.Split('=');

                Add(new KeyValuePair<string, string>(pair[0], Uri.UnescapeDataString(pair[1])));
            }
        }

        internal QueryStringCollection(object parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }

            foreach (var property in parameters.GetType().GetProperties())
            {
                var value = property.GetValue(parameters);

                if (value != null)
                {
                    Add(new KeyValuePair<string, string>(property.Name, value.ToString()));
                }
            }
        }

        public override string ToString()
        {
            if (Count == 0)
            {
                return "";
            }

            var result = new StringBuilder();

            foreach (var item in this)
            {
                result.AppendFormat("{0}={1}&", item.Key, Uri.EscapeDataString(item.Value));
            }

            return result.ToString(0, result.Length - 1);
        }
    }
}
