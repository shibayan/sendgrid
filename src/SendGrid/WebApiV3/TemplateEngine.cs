using System;

namespace SendGrid.WebApiV3
{
    public class TemplateEngine
    {
        internal TemplateEngine(SendGridAccount account)
        {
            _account = account;
        }

        private readonly SendGridAccount _account;

        public object Templates
        {
            get { throw new NotImplementedException(); }
        }

        public object Versions
        {
            get { throw new NotImplementedException(); }
        }
    }
}
