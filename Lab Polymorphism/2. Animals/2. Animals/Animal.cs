﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        protected Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }

    }
}
