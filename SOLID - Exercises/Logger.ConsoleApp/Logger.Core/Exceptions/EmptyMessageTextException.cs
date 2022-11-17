using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exceptions
{
    public class EmptyMessageTextException : Exception
    {
        private const string DEFAULTMESSAGE = "Message text cannot be null or empty!";
        public EmptyMessageTextException() : base(DEFAULTMESSAGE)
        {

        }

        public EmptyMessageTextException(string message) : base(message)
        {

        }
    }
}
