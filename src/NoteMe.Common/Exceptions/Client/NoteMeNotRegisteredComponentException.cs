using System;
using System.Runtime.Serialization;

namespace NoteMe.Common.Exceptions.Client
{
    public class NoteMeNotRegisteredComponentException : NoteMeClientException
    {
        public Type Type { get; }
        
        public NoteMeNotRegisteredComponentException(Type type)
        {
            Type = type;
        }

        protected NoteMeNotRegisteredComponentException(SerializationInfo info, StreamingContext context, Type type) : base(info, context)
        {
            Type = type;
        }

        public NoteMeNotRegisteredComponentException(string message, Type type) : base(message)
        {
            Type = type;
        }

        public NoteMeNotRegisteredComponentException(string message, Exception innerException, Type type) : base(message, innerException)
        {
            Type = type;
        }


    }
}