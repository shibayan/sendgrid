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

        public AlertsFeature Alerts => new AlertsFeature(this);

        public BlocksFeature Blocks => new BlocksFeature(this);

        public BouncesFeature Bounces => new BouncesFeature(this);

        public InvalidEmailsFeature InvalidEmails => new InvalidEmailsFeature(this);

        public SpamReportsFeature SpamReports => new SpamReportsFeature(this);

        public SubUsersFeature SubUsers => new SubUsersFeature(this);

        public UsersFeature Users => new UsersFeature(this);

        public CategoriesFeature Categories => new CategoriesFeature(this);

        public IpManagementFeature IpManagement => new IpManagementFeature(this);

        public ApiKeysFeature ApiKeys => new ApiKeysFeature(this);

        public MailFeature Mail => new MailFeature(this);

        public SettingsFeature Settings => new SettingsFeature(this);

        public StatsFeature Stats => new StatsFeature(this);

        public SuppressionManagementFeature SuppressionManagement => new SuppressionManagementFeature(this);

        public TransactionalTemplatesFeature TransactionalTemplates => new TransactionalTemplatesFeature(this);
    }
}
