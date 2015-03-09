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

        public SendGridWebApiClient CreateWebApiClient()
        {
            return new SendGridWebApiClient(this);
        }

        public SendGridWebApiV3Client CreateWebApiV3Client()
        {
            return new SendGridWebApiV3Client(this);
        }

        public SendGridMarketingEmailsApiClient CreateMarketingEmailsApiClient()
        {
            return new SendGridMarketingEmailsApiClient(this);
        }
    }
}
