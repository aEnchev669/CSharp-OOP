using Logger.Core.Enums;
using Logger.Core.Exceptions;
using Logger.Core.Models.Interfaces;
using Logger.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Models
{
    public class Message : IMessage
    {

        private string? messageText;
        private string? dateTime;

        public Message(string messageText, string dataTime, ReportLevel reportLevel)
        {
            this.MessageText = messageText;
            this.dateTime = dataTime;
            this.ReportLevel = reportLevel;
        }
        public string DateType
        {
            get
            {
                return this.dateTime!;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyDayTimeException();
                }
                if (!DateTimeValidator.IsDateTimeValid(value))
                {
                    throw new InvalidDateTimeException();
                }

                this.dateTime = value;
            }
        }

        public ReportLevel ReportLevel { get; private set; }


        public string MessageText
        {
            get
            {
                return this.DateType;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyMessageTextException();
                }
                this.messageText = value;
            }
        }
    }
}
