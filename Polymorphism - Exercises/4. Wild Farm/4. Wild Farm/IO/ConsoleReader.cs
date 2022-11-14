using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.IO.Inteface;

namespace WildFarm.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
