using System;

namespace G42.Mandate
{
    public static class Mandate
    {
        public static void That<TException>(bool condition, string message) where TException : Exception
        {
            if (!condition)
            {
                var exceptionInstance = (TException)Activator.CreateInstance(typeof(TException), message);

                throw exceptionInstance;
            }
        }
    }
}
