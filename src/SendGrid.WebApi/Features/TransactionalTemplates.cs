using System;

namespace SendGrid.WebApi.Features
{
    public class TransactionalTemplates
    {
        internal TransactionalTemplates(SendGridAccount account)
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
