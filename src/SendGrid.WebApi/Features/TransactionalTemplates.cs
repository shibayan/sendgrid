using System;

namespace SendGrid.WebApi.Features
{
    public class TransactionalTemplates
    {
        internal TransactionalTemplates(Account account)
        {
            _account = account;
        }

        private readonly Account _account;

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
