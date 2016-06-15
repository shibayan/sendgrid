namespace SendGrid.WebApiV3
{
    public class Settings
    {
        internal Settings(SendGridAccount account)
        {
            _account = account;
        }

        private readonly SendGridAccount _account;

        public EnforcedTls EnforcedTls => new EnforcedTls(_account);
    }
}
