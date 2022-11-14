using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        public const double MouseWeightMultiplier = 0.10;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override IReadOnlyCollection<Type> PreferredFoods => new HashSet<Type>() {typeof(Fruit), typeof(Vegetable)};
        protected override double WeightMultiplier => MouseWeightMultiplier;

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
