using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.IO.Inteface;

namespace WildFarm.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(object text) => Console.Write(text.ToString());

        public void WriteLine(object text) => WriteLine(text.ToString());
    }
}
