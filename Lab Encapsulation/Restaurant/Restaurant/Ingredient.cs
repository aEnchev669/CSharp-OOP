using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Ingredient
    {
        public Ingredient(string name, int weightInGrams)
        {
            Name = name;
            WeightInGrams = weightInGrams;
        }

        public string Name { get; set; }
        public int WeightInGrams { get; set; }

    }
}
