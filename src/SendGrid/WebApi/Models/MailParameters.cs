using System;
using System.Collections.Generic;

using SendGrid.Internal;
using SendGrid.Smtp;

namespace SendGrid.WebApi.Models
{
    public class SendMailParameter : ParameterBase
    {
        public SendMailParameter()
        {
            To = new List<string>();
            ToName = new List<string>();
            Cc = new List<string>();
            CcName = new List<string>();
            Bcc = new List<string>();
            BccName = new List<string>();
            Files = new Dictionary<string, string>();
            Content = new Dictionary<string, string>();
            Headers = new Dictionary<string, string>();
        }

        public List<string> To { get; private set; }

        public List<string> ToName { get; private set; }

        public string Subject { get; set; }

        public string Text { get; set; }

        public string Html { get; set; }

        public string From { get; set; }

        public string FromName { get; set; }

        public List<string> Cc { get; private set; }

        public List<string> CcName { get; private set; }

        public List<string> Bcc { get; private set; }

        public List<string> BccName { get; private set; }

        public string ReplyTo { get; set; }

        public DateTimeOffset? Date { get; set; }

        public Dictionary<string, string> Files { get; set; }

        public Dictionary<string, string> Content { get; set; }

        public Dictionary<string, string> Headers { get; set; }

        public SmtpHeader XSmtpApi { get; set; }

        protected override bool UseMultipart
        {
            get { return true; }
        }
    }
}
