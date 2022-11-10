using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class IElectricCar : ICar
    {
        public IElectricCar(string model, string color, int battery) : base(model, color)
        {
            Battery = battery;
        }

        public int Battery { get; set; }
    }
}
