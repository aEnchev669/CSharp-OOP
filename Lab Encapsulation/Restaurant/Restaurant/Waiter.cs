using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Waiter
    {
        private Kitchen kitchen;
        internal void OrderReady(string order)
        {
            Console.WriteLine($"{Name} - Order Ready: {order}");
            
        }
        public void MakeOrder(string order, string special = null)
        {
            Console.WriteLine($"{Name} - Making an order {order}");
            kitchen.TakeOrder(this, order, special);
        }
        public Waiter(string name, Kitchen kitchen)
        {
            Name = name;
            this.kitchen = kitchen;
        }


        public string Name { get; set; }
    }
}
