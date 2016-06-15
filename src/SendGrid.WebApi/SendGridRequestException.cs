using System;
using System.Runtime.Serialization;

namespace SendGrid.WebApi
{
    [Serializable]
    public class SendGridRequestException : Exception
    {
        public SendGridRequestException()
        {
        }

        public SendGridRequestException(string message)
            : base(message)
        {
        }

        public SendGridRequestException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected SendGridRequestException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
