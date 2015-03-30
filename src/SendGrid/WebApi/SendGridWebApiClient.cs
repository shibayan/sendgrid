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

        public Blocks Blocks
        {
            get { return new Blocks(_account); }
        }

        public Bounces Bounces
        {
            get { return new Bounces(_account); }
        }

        public Credentials Credentials
        {
            get { return new Credentials(_account); }
        }

        public Filters Filters
        {
            get { return new Filters(_account); }
        }

        public InvalidEmails InvalidEmails
        {
            get { return new InvalidEmails(_account); }
        }

        public Mail Mail
        {
            get { return new Mail(_account); }
        }

        public ParseWebhook ParseWebhook
        {
            get { return new ParseWebhook(_account); }
        }

        public Profile Profile
        {
            get { return new Profile(_account); }
        }

        public SpamReports SpamReports
        {
            get { return new SpamReports(_account); }
        }

        public Timezone Timezone
        {
            get { return new Timezone(_account); }
        }

        public Unsubscribes Unsubscribes
        {
            get { return new Unsubscribes(_account); }
        }

        #endregion
    }
}
