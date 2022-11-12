using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exceptions
{
    public class InvalidURLException : Exception
    {
        private const string DefaultMessage = "Invalid URL!";
        public InvalidURLException(): base(DefaultMessage)
        {
        }
        public InvalidURLException(string message) : base(message)
        {
        }

    }
}
