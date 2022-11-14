using Raiding.Core;
using Raiding.Core.Interfaces;
using Raiding.IO;
using Raiding.IO.Interfaces;
using System;

namespace Raiding
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            
            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
