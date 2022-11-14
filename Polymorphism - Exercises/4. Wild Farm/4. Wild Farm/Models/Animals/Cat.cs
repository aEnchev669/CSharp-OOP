using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        public const double CatWeightMultiplier = 0.30;

        public Cat(string name, double weight, string bread, string livingRegion) : base(name, weight, livingRegion, bread)
        {
        }

        public override IReadOnlyCollection<Type> PreferredFoods => new HashSet<Type>() { typeof(Meat), typeof(Vegetable)};

        protected override double WeightMultiplier => CatWeightMultiplier;

        public override string ProduceSound() => "Meow";
    }
}
