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

        public AdvancedSuppressionManager AdvancedSuppressionManage => new AdvancedSuppressionManager(_account);

        public Categories Categories => new Categories(_account);

        public IpManagement IpManagement => new IpManagement(_account);

        public Settings Settings => new Settings(_account);

        public TemplateEngine TemplateEngine => new TemplateEngine(_account);

        #endregion
    }
}
