namespace SendGrid.MarketingEmailsApi
{
    public class SendGridMarketingEmailsApiClient
    {
        public SendGridMarketingEmailsApiClient(SendGridAccount account)
        {
            _account = account;
        }

        private readonly SendGridAccount _account;

        #region Marketing Emails API

        public MarketingEmails MarketingEmails
        {
            get { return new MarketingEmails(_account); }
        }

        #endregion
    }
}
