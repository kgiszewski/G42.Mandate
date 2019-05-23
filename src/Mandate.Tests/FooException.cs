using System;

namespace Mandate.Tests
{
    public class FooException : Exception
    {
        public object[] Args;

        public FooException(string message, object[] args)
            :base(message)
        {
            Args = args;
        }
    }
}
