using System;

namespace Mg.Company.Common.Utils
{
    public class CustomExeption : Exception
    {
        public CustomExeption() : base()
        {
        }

        public CustomExeption(string message) : base(message)
        {
        }

        public CustomExeption(string message, Exception inner) : base(message, inner)
        {
        }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected CustomExeption(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
