
namespace Vehicles
{
    using System;

    using Core;
    using Vehicles.Core.Intefaces;
    using Vehicles.Factories;
    using Vehicles.Factories.Interfaces;
    using Vehicles.IO;
    using Vehicles.IO.Interfaces;

    public class StartUp
    {
        static void Main(string[] args)
        {

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IVehicleFactory vehicleFactory = new VehicleFactory();
            IEngine engine = new Engine(reader,writer,vehicleFactory);
            engine.Run();
        }
    }
}
