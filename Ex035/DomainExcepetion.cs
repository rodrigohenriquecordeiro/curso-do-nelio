using System;
using System.Runtime.Serialization;

namespace Ex035
{
    [Serializable]
    internal class DomainExcepetion : Exception
    {
        public DomainExcepetion()
        {
        }

        public DomainExcepetion(string message) : base(message)
        {
        }

        public DomainExcepetion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DomainExcepetion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}