 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Layouts.Interfaces
{
    public interface ILayout
    {
        string Format { get; }
        string FormatMessage();
    }
}
