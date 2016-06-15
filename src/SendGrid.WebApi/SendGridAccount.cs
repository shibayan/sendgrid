using System;

using SendGrid.WebApi.Features;

namespace SendGrid.WebApi
{
    public sealed class SendGridAccount
    {
        private SendGridAccount(string apiKey)
        {
            if (apiKey == null)
            {
                throw new ArgumentNullException(nameof(apiKey));
            }
            
            ApiKey = apiKey;
        }

        #region Internal
        
        internal string ApiKey { get; }

        #endregion

        #region Public Methods

        public static SendGridAccount Create(string apiKey)
        {
            return new SendGridAccount(apiKey);
        }

        #endregion

        public Alerts Alerts => new Alerts(this);

        public Blocks Blocks => new Blocks(this);

        public Bounces Bounces => new Bounces(this);

        public InvalidEmails InvalidEmails => new InvalidEmails(this);

        public SpamReports SpamReports => new SpamReports(this);

        public Categories Categories => new Categories(this);

        public IpManagement IpManagement => new IpManagement(this);

        public Mail Mail => new Mail(this);

        public Settings Settings => new Settings(this);

        public SuppressionManagement SuppressionManagement => new SuppressionManagement(this);

        public TransactionalTemplates TransactionalTemplates => new TransactionalTemplates(this);
    }
}
