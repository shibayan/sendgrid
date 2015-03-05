namespace SendGrid.WebApiV3
{
    public class Settings
    {
        internal Settings(SendGridAccount account)
        {
            _account = account;
        }

        private readonly SendGridAccount _account;

        public EnforcedTls EnforcedTls
        {
            get { return new EnforcedTls(_account); }
        }
    }
}
