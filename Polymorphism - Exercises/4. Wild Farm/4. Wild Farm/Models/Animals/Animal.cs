using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Exceptions;
using WildFarm.Models.Intefaces;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private Animal()
        {
            this.FoodEaten = 0;
        }
        protected Animal(string name, double weight) : this()
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; private set; }

        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        public abstract IReadOnlyCollection<Type> PreferredFoods { get;}
        protected abstract double WeightMultiplier { get; }
        public void Eat(IFood food)
        {
            if (!this.PreferredFoods.Any(t => t.Name == food.GetType().Name))
            {
                throw new FoodNotEatenException(string.Format(ExcpetionMessages.FoodNotEatenException, this.GetType().Name, food.GetType().Name));
            }
            this.Weight += food.Quantity * this.WeightMultiplier;
            this.FoodEaten += food.Quantity;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
