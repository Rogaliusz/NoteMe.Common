using System;
using System.Runtime.Serialization;

namespace NoteMe.Common.Exceptions.Client
{
    public class NoteMeClientException : Exception
    {
        public NoteMeClientException()
        {
        }

        protected NoteMeClientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public NoteMeClientException(string message) : base(message)
        {
        }

        public NoteMeClientException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}