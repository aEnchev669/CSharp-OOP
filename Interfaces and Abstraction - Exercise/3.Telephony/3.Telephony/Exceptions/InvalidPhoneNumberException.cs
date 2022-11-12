using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string DefaultExceptionMessage = "Invalid number!";

        public InvalidPhoneNumberException(): base(DefaultExceptionMessage)
        {

        }

        public InvalidPhoneNumberException(string message) : base(message)
        {

        }
    }
}
