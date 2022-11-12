
namespace Telephony
{
    using System;
    using IO;
    using IO.Interfaces;
    using Core.Interfaces;
    using Core;

    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader,writer);
            engine.Run();
        }
    }
}
