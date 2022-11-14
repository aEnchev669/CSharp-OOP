



namespace Vehicles.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Intefaces;
    using Models;
    using Vehicles.Exception;
    using Vehicles.Exceptions;
    using Vehicles.Factories.Interfaces;
    using Vehicles.IO.Interfaces;
    using Vehicles.Models.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IVehicleFactory vehicleFactory;

        private readonly ICollection<IVehicle> vehicles;

        public Engine()
        {
            this.vehicles = new HashSet<IVehicle>();
        }

        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory) : this()
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }

        public void Run()
        {
            this.vehicles.Add(this.BuildVehicleUsingFactory());
            this.vehicles.Add(this.BuildVehicleUsingFactory());

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    this.ProccesCommand();
                }
                catch (FuelException fe)
                {
                    this.writer.WriteLine(fe.Message);
                }
                catch (InvalidVehicleTypeException ivty)
                {
                    this.writer.WriteLine(ivty.Message);
                }
                catch (Exception e)
                {
                    this.writer.WriteLine(e.Message);
                }

            }

            this.Print();

        }

        private IVehicle BuildVehicleUsingFactory()
        {
            string[] vehicleArgs = this.reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string vehicleType = vehicleArgs[0];
            double vehicleFuelQty = double.Parse(vehicleArgs[1]);
            double vehicleFuelConsm = double.Parse(vehicleArgs[2]);

            IVehicle vehicle = this.vehicleFactory.CreateVehicle(vehicleType, vehicleFuelQty, vehicleFuelConsm);
            return vehicle;
        }

        private void ProccesCommand()
        {
            string[] cmdArgs = this.reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string cmdType = cmdArgs[0];
            string vehicleType = cmdArgs[1];
            double args = double.Parse(cmdArgs[2]);


            if (vehicleType == null)
            {
                throw new InvalidVehicleTypeException();
            }
            IVehicle vehicleToProcess = this.vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);
            if (cmdType == "Drive")
            {
                this.writer.WriteLine(vehicleToProcess.Drive(args));
            }
            else if (cmdType == "Refuel")
            {
                vehicleToProcess.Refuel(args);
            }
        }

        private void Print()
        {
            foreach (IVehicle vehicle in this.vehicles)
            {
                this.writer.WriteLine(vehicle.ToString());
            }
        }
    }
}
