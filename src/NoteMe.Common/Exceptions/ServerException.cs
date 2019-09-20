using System;
using System.Runtime.Serialization;

namespace NoteMe.Common.Exceptions
{
    public class ServerException : Exception
    {
        public string Code { get; }
        
        public ServerException(string code)
        {
            Code = code;
        }

        public ServerException(SerializationInfo info, StreamingContext context, string code) : base(info, context)
        {
            Code = code;
        }

        public ServerException(string message, string code) : base(message)
        {
            Code = code;
        }

        public ServerException(string message, Exception innerException, string code) : base(message, innerException)
        {
            Code = code;
        }
    }
}