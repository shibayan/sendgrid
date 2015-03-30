namespace SendGrid.WebApiV3
{
    public class SendGridWebApiV3Client
    {
        public SendGridWebApiV3Client(SendGridAccount account)
        {
            _account = account;
        }

        private readonly SendGridAccount _account;

        #region Web API v3

        public AdvancedSuppressionManager AdvancedSuppressionManage
        {
            get { return new AdvancedSuppressionManager(_account); }
        }

        public Categories Categories
        {
            get { return new Categories(_account); }
        }

        public IpManagement IpManagement
        {
            get { return new IpManagement(_account); }
        }

        public Settings Settings
        {
            get { return new Settings(_account); }
        }

        public TemplateEngine TemplateEngine
        {
            get { return new TemplateEngine(_account); }
        }

        #endregion
    }
}
