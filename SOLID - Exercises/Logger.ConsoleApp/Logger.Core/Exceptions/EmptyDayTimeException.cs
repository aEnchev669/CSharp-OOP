using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exceptions
{
    public class EmptyDayTimeException : Exception
    {
        private const string DefaultMessage = "DateTime message cannot be null or whitespace!";
        public EmptyDayTimeException(): base(DefaultMessage)
        {

        }

        public EmptyDayTimeException(string text) : base (text)
        {

        }
    }
}
