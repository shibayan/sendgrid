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

        public AdvancedSuppressionManager AdvancedSuppressionManage => new AdvancedSuppressionManager(this);

        public Categories Categories => new Categories(this);

        public IpManagement IpManagement => new IpManagement(this);

        public Settings Settings => new Settings(this);

        public TemplateEngine TemplateEngine => new TemplateEngine(this);
    }
}
