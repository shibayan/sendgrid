using System.Collections.Generic;

namespace SendGrid.SmtpApi
{
    public static class SmtpHeaderExtensions
    {
        public static SmtpHeader UseBcc(this SmtpHeader header, string email)
        {
            header.AddFilter("bcc", new Dictionary<string, object>
            {
                { "enable", 1 },
                { "email", email }
            });

            return header;
        }

        public static SmtpHeader UseBypassListManagement(this SmtpHeader header)
        {
            header.AddFilter("bypass_list_management", new Dictionary<string, object>
            {
                { "enable", 1 }
            });

            return header;
        }

        public static SmtpHeader UseClickTrack(this SmtpHeader header)
        {
            header.AddFilter("clicktrack", new Dictionary<string, object>
            {
                { "enable", 1 }
            });

            return header;
        }

        public static SmtpHeader UseDkim(this SmtpHeader header, string domain, bool useFrom)
        {
            header.AddFilter("dkim", new Dictionary<string, object>
            {
                { "domain", domain },
                { "use_from", useFrom }
            });

            return header;
        }

        public static SmtpHeader UseDomainKeys(this SmtpHeader header, string domain, bool sender)
        {
            header.AddFilter("domainkeys", new Dictionary<string, object>
            {
                { "enable", 1 },
                { "domain", domain },
                { "sender", sender }
            });

            return header;
        }

        public static SmtpHeader UseFooter(this SmtpHeader header, string html, string text)
        {
            header.AddFilter("footer", new Dictionary<string, object>
            {
                { "enable", 1 },
                { "text/html", html },
                { "text/plain", text }
            });

            return header;
        }

        public static SmtpHeader UseForwardSpam(this SmtpHeader header, string email)
        {
            header.AddFilter("forwardspam", new Dictionary<string, object>
            {
                { "enable", 1 },
                { "email", email }
            });

            return header;
        }

        public static SmtpHeader UseGoogleAnalytics(this SmtpHeader header, string source, string medium, string term, string content, string campaign)
        {
            header.AddFilter("ganalytics", new Dictionary<string, object>
            {
                { "enable", 1 },
                { "utm_source", source },
                { "utm_medium", medium },
                { "utm_term", term },
                { "utm_content", content },
                { "utm_campaign", campaign }
            });

            return header;
        }

        public static SmtpHeader UseGravatar(this SmtpHeader header)
        {
            header.AddFilter("gravatar", new Dictionary<string, object>
            {
                { "enable", 1 }
            });

            return header;
        }

        public static SmtpHeader UseOpenTrack(this SmtpHeader header)
        {
            header.AddFilter("opentrack", new Dictionary<string, object>
            {
                { "enable", 1 }
            });

            return header;
        }

        public static SmtpHeader UseSpamCheck(this SmtpHeader header, double maxscore, string url)
        {
            header.AddFilter("spamcheck", new Dictionary<string, object>
            {
                { "enable", 1 },
                { "maxscore", maxscore },
                { "url", url }
            });

            return header;
        }

        public static SmtpHeader UseSubscriptionTrack(this SmtpHeader header, string html, string text, string replace)
        {
            header.AddFilter("subscriptiontrack", new Dictionary<string, object>
            {
                { "enable", 1 },
                { "text/html", html },
                { "text/plain", text },
                { "replace", replace }
            });

            return header;
        }

        public static SmtpHeader UseTemplateEngine(this SmtpHeader header, string templateId)
        {
            header.AddFilter("templates", new Dictionary<string, object>
            {
                { "enable", 1 },
                { "template_id", templateId },
            });

            return header;
        }

        public static SmtpHeader UseTemplate(this SmtpHeader header, string html)
        {
            header.AddFilter("template", new Dictionary<string, object>
            {
                { "enable", 1 },
                { "text/html", html },
            });

            return header;
        }
    }
}
