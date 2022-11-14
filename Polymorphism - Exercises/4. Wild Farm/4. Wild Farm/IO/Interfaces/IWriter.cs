using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.IO.Inteface
{
    public interface IWriter
    {
        void Write(object text);
        void WriteLine(object text);
    }
}
