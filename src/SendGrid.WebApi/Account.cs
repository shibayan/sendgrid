using System;

using SendGrid.WebApi.Features;

namespace SendGrid.WebApi
{
    public sealed class Account
    {
        private Account(string apiKey)
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

        public static Account Create(string apiKey)
        {
            return new Account(apiKey);
        }

        #endregion

        public Alerts Alerts => new Alerts(this);

        public Blocks Blocks => new Blocks(this);

        public Bounces Bounces => new Bounces(this);

        public InvalidEmails InvalidEmails => new InvalidEmails(this);

        public SpamReports SpamReports => new SpamReports(this);

        public SubUsers SubUsers => new SubUsers(this);

        public Users Users => new Users(this);

        public Categories Categories => new Categories(this);

        public IpManagement IpManagement => new IpManagement(this);

        public ApiKeys ApiKeys => new ApiKeys(this);

        public Mail Mail => new Mail(this);

        public Settings Settings => new Settings(this);

        public Stats Stats => new Stats(this);

        public SuppressionManagement SuppressionManagement => new SuppressionManagement(this);

        public TransactionalTemplates TransactionalTemplates => new TransactionalTemplates(this);
    }
}
