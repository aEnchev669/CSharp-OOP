using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factories.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string type, double fuelQuantyti, double fuelConsumption);
    }
}
