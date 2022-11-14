using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Exceptions;
using Vehicles.Factories.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory
    {

        public VehicleFactory()
        {

        }
        public IVehicle CreateVehicle(string type, double fuelQuantyti, double fuelConsumption)
        {
            IVehicle vehicle;

            if (type == "Car")
            {
                vehicle = new Car(fuelQuantyti, fuelConsumption);
            }
            else if (type == "Truck")
            {
                vehicle = new Truck(fuelQuantyti, fuelConsumption);
            }
            else
            {
                throw new InvalidVehicleTypeException();
            }

            return vehicle;
        }
    }
}
