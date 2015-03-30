using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SendGrid.Internal
{
    internal class QueryStringCollection : List<KeyValuePair<string, string>>
    {
        internal QueryStringCollection()
        {
        }

        internal QueryStringCollection(string queryString)
        {
            if (queryString == null)
            {
                throw new ArgumentNullException("queryString");
            }

            foreach (var item in queryString.TrimStart('?').Split('&').Select(x => x.Split('=')))
            {
                Add(item[0], Uri.UnescapeDataString(item[1]));
            }
        }

        public void Add(string key, string value)
        {
            Add(new KeyValuePair<string, string>(key, value));
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

            return "?" + result.ToString(0, result.Length - 1);
        }
    }
}
