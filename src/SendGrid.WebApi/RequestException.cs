using System;
using System.Runtime.Serialization;

namespace SendGrid.WebApi
{
    [Serializable]
    public class RequestException : Exception
    {
        public RequestException()
        {
        }

        public RequestException(string message)
            : base(message)
        {
        }

        public RequestException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected RequestException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
