using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantitiy { get; }
        public double FuelConsumption { get;}
        string Drive(double km);
        void Refuel(double liters);

        
    }
}
