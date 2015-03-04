using System;

using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public sealed class SendMailParameter : ParameterBase
    {
        public string From { get; set; }

        public string FromName { get; set; }

        public string ReplyTo { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }

        public string Html { get; set; }

        public DateTimeOffset? Date { get; set; }

        protected override bool UseMultipart
        {
            get { return true; }
        }
    }
}
