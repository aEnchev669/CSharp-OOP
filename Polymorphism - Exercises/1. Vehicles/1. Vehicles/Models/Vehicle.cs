using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Exception;
using Vehicles.Exceptions;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double fuelConsumptionIncrement)
        {
            this.FuelQuantitiy = fuelQuantity;
            this.FuelConsumption = fuelConsumption + fuelConsumptionIncrement;
        }
        public double FuelQuantitiy { get; private set; }

        public double FuelConsumption { get; private set; }
        public string Drive(double km)
        {
            if (FuelQuantitiy - km * FuelConsumption <= 0)
            {
                throw new FuelException(string.Format(ExceptionMessages.FuelExceptionMessage, this.GetType().Name));
            }

            this.FuelQuantitiy -= km * FuelConsumption;
            return $"{this.GetType().Name} travelled {km} km";
        }

        public virtual void Refuel(double liters)
        {
            this.FuelQuantitiy += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantitiy:f2}";
        }
    }
}
