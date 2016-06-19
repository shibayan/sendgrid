using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Mvc;

using SendGrid.WebHooks.Internal;

namespace SendGrid.WebHooks.Parse
{
    public class ParseToAttribute : ActionMethodSelectorAttribute
    {
        public ParseToAttribute(string address)
        {
            _addressPattern = new Regex(address, RegexOptions.Compiled | RegexOptions.ECMAScript);
        }

        public ParseToAttribute(params string[] addressList)
        {
            _addressPattern = new Regex(string.Join("|", addressList), RegexOptions.Compiled | RegexOptions.ECMAScript);
        }

        private readonly Regex _addressPattern;

        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            var envelope = controllerContext.HttpContext.Request.AsJson<Envelope>("envelope");

            if (envelope == null)
            {
                return false;
            }

            return envelope.To.Any(p => _addressPattern.IsMatch(p));
        }
    }
}