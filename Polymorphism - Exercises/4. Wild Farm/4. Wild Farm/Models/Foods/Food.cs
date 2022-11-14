using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Intefaces;

namespace WildFarm.Models.Foods
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.Quantity}";
        }
    }
}
