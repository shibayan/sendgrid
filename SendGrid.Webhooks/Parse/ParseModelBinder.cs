using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

using SendGrid.Webhooks.Internal;

namespace SendGrid.Webhooks.Parse
{
    public class ParseModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;

            return new ParseInfo
            {
                Headers = request.AsString("headers"),
                Text = request.AsString("text"),
                Html = request.AsString("html"),
                From = ParseMailAddress(request.AsString("from")),
                To = ParseMailAddresses(request, "to"),
                Cc = ParseMailAddresses(request, "cc"),
                Subject = request.AsString("subject"),
                Dkim = request.AsString("dkim"),
                Spf = request.AsString("SPF"),
                Envelope = request.AsJson<Envelope>("envelope"),
                Charsets = request.AsJson<Charsets>("charsets"),
                SpamScore = request.AsDouble("spam_score"),
                SpamReport = request.AsString("spam_report"),
                SenderIp = request.AsString("sender_ip"),
                Attachments = ParseAttachments(request)
            };
        }

        private static readonly Regex[] _mailAddressPattern =
        {
            new Regex(@"^(.+) <(.+)>$", RegexOptions.Compiled | RegexOptions.ECMAScript)
        };

        private static MailAddress ParseMailAddress(string mailAddress)
        {
            if (string.IsNullOrEmpty(mailAddress))
            {
                return null;
            }

            var match = _mailAddressPattern.Select(p => p.Match(mailAddress)).FirstOrDefault(p => p.Success);

            if (match == null)
            {
                return new MailAddress
                {
                    Address = mailAddress
                };
            }

            return new MailAddress
            {
                Name = match.Groups[1].Value,
                Address = match.Groups[2].Value
            };
        }

        private static IList<MailAddress> ParseMailAddresses(HttpRequestBase request, string key)
        {
            var values = request.AsStringArray(key, ',');

            return values.Select(ParseMailAddress).ToArray();
        }

        private static IList<Attachment> ParseAttachments(HttpRequestBase request)
        {
            var count = request.AsInt("attachments");
            var info = request.AsJson("attachment-info");

            var attachments = new List<Attachment>();

            for (int i = 1; i <= count; i++)
            {
                var item = info["attachment" + i];

                attachments.Add(new Attachment
                {
                    Type = item.type,
                    Name = item.name,
                    FileName = item.filename,
                    Content = request.Files["attachment" + i]
                });
            }

            return attachments;
        }
    }
}