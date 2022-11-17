using Logger.Core.Appenders.Interfaces;
using Logger.Core.Formatting;
using Logger.Core.Formatting.Interfaces;
using Logger.Core.Layouts.Interfaces;
using Logger.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private IFormatter formatter;

        public ConsoleAppender()
            
        {
            this.formatter = new MessageFormatter();
        }
        public ConsoleAppender(ILayout layout)
            : this()
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; private set; }

        public void AppendMessage(IMessage message)
        {
            string output = this.formatter
        }
    }
}
