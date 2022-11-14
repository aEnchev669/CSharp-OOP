using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Intefaces;

namespace WildFarm.Models.Animals
{
    public abstract class Mammal : Animal,IMammal
    {
        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }
        public string LivingRegion { get; private set; }
    }
}
