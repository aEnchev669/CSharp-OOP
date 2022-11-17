using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exceptions
{
    public class InvlaidFileName : Exception
    {
        private const string DEFAULTMESSAGE = "File name cannot be null or empty!";
        public InvlaidFileName() : base(DEFAULTMESSAGE)
        {

        }
        public InvlaidFileName(string message) : base(message)
        {

        }
    }
}
