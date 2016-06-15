using System;
using System.Text.RegularExpressions;

using SendGrid.MarketingEmailsApi;
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
                throw new ArgumentNullException(nameof(apiUser));
            }

            if (apiKey == null)
            {
                throw new ArgumentNullException(nameof(apiKey));
            }

            ApiUser = apiUser;
            ApiKey = apiKey;
        }

        #region Internal

        internal string ApiUser { get; }

        internal string ApiKey { get; }

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

        public SendGridWebApiClient CreateWebApiClient()
        {
            return new SendGridWebApiClient(this);
        }

        public SendGridWebApiV3Client CreateWebApiV3Client()
        {
            return new SendGridWebApiV3Client(this);
        }

        public MarketingEmailsApiClient CreateMarketingEmailsApiClient()
        {
            return new MarketingEmailsApiClient(this);
        }
    }
}
