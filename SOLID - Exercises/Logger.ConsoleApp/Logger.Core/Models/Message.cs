using Logger.Core.Enums;
using Logger.Core.Exceptions;
using Logger.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Models
{
    public class Message : IMessage
    {

        private string messageText;
        private string dateTime;

        public Message(string messageText, string dataTime, ReportLevel reportLevel)
        {
            this.MessageText = messageText;

        }
        public string DateType
        {
            get
            {
                return this.dateTime;
            }
            private set
            {

            }
        }

        public ReportLevel reportLevel { get; private set; }

        public string MessageText
        {
            get
            {
                return this.DateType;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(messageText))
                {
                    throw new EmptyMessageTextException();
                }
                this.messageText = value;
            }
        }
    }
}
