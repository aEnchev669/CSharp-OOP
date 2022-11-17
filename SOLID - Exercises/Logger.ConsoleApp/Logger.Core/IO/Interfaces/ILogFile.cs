using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.IO.Interfaces
{
    public interface ILogFile
    {
        string Name { get; }
        string Path { get; }
        int Size { get; }
        string Content { get; }
        void Write(string text);
    }
}
