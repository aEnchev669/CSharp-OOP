using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Intefaces;

namespace WildFarm.Models.Animals
{
    public abstract class Feline : Mammal, IFeline
    {
        protected Feline(string name, double weight, string breed, string livingRegion) : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; private set; }

        public override string ToString()
        {
            return base.ToString() +
               $"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
