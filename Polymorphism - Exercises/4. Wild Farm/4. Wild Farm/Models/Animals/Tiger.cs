using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public const double TigerWeightMultiplier = 1;

        public Tiger(string name, double weight, string bread, string livingRegion) : base(name, weight, bread, livingRegion)
        {
        }

        public override IReadOnlyCollection<Type> PreferredFoods => new HashSet<Type>() { typeof(Meat)};

        protected override double WeightMultiplier => TigerWeightMultiplier;

        public override string ProduceSound() => "ROAR!!!";
    }
}
