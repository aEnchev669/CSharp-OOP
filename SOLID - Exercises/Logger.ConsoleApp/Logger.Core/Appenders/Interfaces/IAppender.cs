﻿using Logger.Core.Layouts.Interfaces;
using Logger.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Appenders.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }

         void AppendMessage(IMessage message);
    }
}
