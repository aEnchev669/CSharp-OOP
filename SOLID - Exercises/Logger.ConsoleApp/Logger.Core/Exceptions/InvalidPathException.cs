using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exceptions
{
    public class InvalidPathException : Exception
    {
        private const string DEFAULTMESSAGE = "Provided path does not exist or it is invalid";

        public InvalidPathException() : base(DEFAULTMESSAGE)
        {

        }
        public InvalidPathException(string message) : base(message)
        {

        }
    }
}
