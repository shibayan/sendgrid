using System.Net.Http;
using System.Text;

using Newtonsoft.Json;

namespace SendGrid.WebApi.Internal
{
    public class JsonContent : StringContent
    {
        public JsonContent(object content)
            : base(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json")
        {
        }
    }
}
