using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exceptions
{
    public class InvalidDateTimeException : Exception
    {
        private const string DefaultMessage = "Provided DateTime not supported! Try register it using Validator.RegisterNewFormat() method!";

        public InvalidDateTimeException() : base(DefaultMessage)
        {

        }

        public InvalidDateTimeException(string text) : base(text)
        {

        }
    }
}
