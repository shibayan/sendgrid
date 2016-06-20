namespace SendGrid.WebApi.Features
{
    public class Settings
    {
        internal Settings(Account account)
        {
            _account = account;
        }

        private readonly Account _account;

        public EnforcedTls EnforcedTls => new EnforcedTls(_account);
    }
}
