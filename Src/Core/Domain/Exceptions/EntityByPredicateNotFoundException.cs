using System;
using System.Runtime.Serialization;

namespace SampleAspNet.Domain.Exceptions
{
    [Serializable]
    public class EntityByPredicateNotFoundException : Exception
    {
        public EntityByPredicateNotFoundException() : base("No data was found for the transmitted predicate in the database.")
        {
        }

        public EntityByPredicateNotFoundException(string message) : base(message)
        {
        }

        public EntityByPredicateNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }

        protected EntityByPredicateNotFoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}