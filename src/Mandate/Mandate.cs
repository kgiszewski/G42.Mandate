using System;

namespace G42.Mandate
{
    public static class Mandate
    {
        public static void That<TException>(bool condition, string message = "", object[] args = null) where TException : Exception
        {
            if (!condition)
            {
                _throw<TException>(message, args);
            }
        }

        public static void IsNotNull<TException>(object input, string message = "", object[] args = null) where TException : Exception
        {
            if (input == null)
            {
                _throw<TException>(message, args);
            }
        }

        private static void _throw<TException>(string message, object[] args) where TException : Exception
        {
            if (args == null)
            {
                throw (TException)Activator.CreateInstance(typeof(TException), message);
            }

            throw (TException)Activator.CreateInstance(typeof(TException), message, args);
        }
    }
}