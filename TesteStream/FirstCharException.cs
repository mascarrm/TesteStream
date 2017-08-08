using System;

namespace TesteStream
{
    [Serializable]
    public class FirstCharException : Exception
    {
        public FirstCharException() { }
        public FirstCharException(string message) : base(message) { }
        public FirstCharException(string message, Exception inner) : base(message, inner) { }
        protected FirstCharException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
