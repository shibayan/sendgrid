namespace SendGrid.WebApi.Features
{
    public class SettingsFeature
    {
        internal SettingsFeature(Account account)
        {
            _account = account;
        }

        private readonly Account _account;

        public EnforcedTlsFeature EnforcedTls => new EnforcedTlsFeature(_account);
    }
}
