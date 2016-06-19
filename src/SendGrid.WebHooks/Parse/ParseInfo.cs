using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace SendGrid.WebHooks.Parse
{
    [ModelBinder(typeof(ParseModelBinder))] 
    public class ParseInfo
    {
        public string Headers { get; set; }
        public string Text { get; set; }
        public string Html { get; set; }
        public MailAddress From { get; set; }
        public IList<MailAddress> To { get; set; }
        public IList<MailAddress> Cc { get; set; }
        public string Subject { get; set; }
        public string Dkim { get; set; }
        public string Spf { get; set; }
        public Envelope Envelope { get; set; }
        public Charsets Charsets { get; set; }
        public double SpamScore { get; set; }
        public string SpamReport { get; set; }
        public string SenderIp { get; set; }
        public IList<Attachment> Attachments { get; set; }
    }

    public class MailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Envelope
    {
        public IList<string> To { get; set; }
        public string From { get; set; }
    }

    public class Attachment
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public HttpPostedFileBase Content { get; set; }
    }

    public class Charsets
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Html { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
    }
}