namespace SendGrid.MarketingEmailsApi
{
    public class MarketingEmailsApiClient
    {
        public MarketingEmailsApiClient(SendGridAccount account)
        {
            _account = account;
        }

        private readonly SendGridAccount _account;

        #region Marketing Emails API

        public Categories Categories
        {
            get { return new Categories(_account); }
        }

        public Emails Emails
        {
            get { return new Emails(_account); }
        }

        public Identity Identity
        {
            get { return new Identity(_account); }
        }

        public Lists Lists
        {
            get { return new Lists(_account); }
        }

        public MarketingEmails MarketingEmails
        {
            get { return new MarketingEmails(_account); }
        }

        public Recipients Recipients
        {
            get { return new Recipients(_account); }
        }

        public Schedule Schedule
        {
            get { return new Schedule(_account); }
        }

        public Variations Variations
        {
            get { return new Variations(_account); }
        }

        #endregion
    }
}
