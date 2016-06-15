namespace SendGrid.WebApi
{
    public class SendGridWebApiClient
    {
        public SendGridWebApiClient(SendGridAccount account)
        {
            _account = account;
        }

        private readonly SendGridAccount _account;

        #region Web API

        public Blocks Blocks => new Blocks(_account);

        public Bounces Bounces => new Bounces(_account);

        public Credentials Credentials => new Credentials(_account);

        public Filters Filters => new Filters(_account);

        public InvalidEmails InvalidEmails => new InvalidEmails(_account);

        public Mail Mail => new Mail(_account);

        public ParseWebhook ParseWebhook => new ParseWebhook(_account);

        public Profile Profile => new Profile(_account);

        public SpamReports SpamReports => new SpamReports(_account);

        public Timezone Timezone => new Timezone(_account);

        public Unsubscribes Unsubscribes => new Unsubscribes(_account);

        #endregion
    }
}
