using System;
using System.Text.RegularExpressions;

using SendGrid.WebApi;
using SendGrid.WebApiV3;

namespace SendGrid
{
    public sealed class SendGridAccount
    {
        private SendGridAccount(string apiUser, string apiKey)
        {
            if (apiUser == null)
            {
                throw new ArgumentNullException("apiUser");
            }

            if (apiKey == null)
            {
                throw new ArgumentNullException("apiKey");
            }

            _apiUser = apiUser;
            _apiKey = apiKey;
        }

        private readonly string _apiUser;
        private readonly string _apiKey;

        #region Internal

        internal string ApiUser
        {
            get { return _apiUser; }
        }

        internal string ApiKey
        {
            get { return _apiKey; }
        }

        #endregion

        #region Public Methods

        public static SendGridAccount Create(string apiUser, string apiKey)
        {
            return new SendGridAccount(apiUser, apiKey);
        }

        public static SendGridAccount Parse(string connectionString)
        {
            var match = Regex.Match(connectionString, "^ApiUser=([^;]+);ApiKey=([^;]+)$;?", RegexOptions.Compiled);

            if (!match.Success)
            {
                return null;
            }

            return new SendGridAccount(match.Groups[1].Value, match.Groups[2].Value);
        }

        #endregion

        #region Web API

        public Blocks Blocks
        {
            get { return new Blocks(this); }
        }

        public Bounces Bounces
        {
            get { return new Bounces(this); }
        }

        public Credentials Credentials
        {
            get { return new Credentials(this); }
        }

        public Filters Filters
        {
            get { return new Filters(this); }
        }

        public InvalidEmails InvalidEmails
        {
            get { return new InvalidEmails(this); }
        }

        public Mail Mail
        {
            get { return new Mail(this); }
        }

        public ParseWebhook ParseWebhook
        {
            get { return new ParseWebhook(this); }
        }

        public Profile Profile
        {
            get { return new Profile(this); }
        }

        public SpamReports SpamReports
        {
            get { return new SpamReports(this); }
        }

        public Timezone Timezone
        {
            get { return new Timezone(this); }
        }

        public Unsubscribes Unsubscribes
        {
            get { return new Unsubscribes(this); }
        }

        #endregion

        #region Web API v3

        public AdvancedSuppressionManager AdvancedSuppressionManage
        {
            get { return new AdvancedSuppressionManager(this); }
        }

        public Categories Categories
        {
            get { return new Categories(this); }
        }

        public IpManagement IpManagement
        {
            get { return new IpManagement(this); }
        }

        public Settings Settings
        {
            get { return new Settings(this); }
        }

        public TemplateEngine TemplateEngine
        {
            get { return new TemplateEngine(this); }
        }

        #endregion

        #region Marketing Emails API

        public object MarketingEmails
        {
            get { return null; }
        }

        #endregion
    }
}
