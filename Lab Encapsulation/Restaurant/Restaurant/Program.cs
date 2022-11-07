using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("Onion", 5000),
                new Ingredient("Tomatoe", 10000),
                new Ingredient("Chicken", 10000),
                new Ingredient("Rise", 20000),
                new Ingredient("Olive oil", 5000)
        };
            Kitchen kitchen = new Kitchen(ingredients);

            Waiter penkaWaiter = new Waiter("Penka", kitchen);
            Waiter goshoWaiter = new Waiter("Gosho", kitchen);

            List<Waiter> waiters = new List<Waiter>() { penkaWaiter, goshoWaiter};
            Random random = new Random();
            while (true)
            {
                string order = Console.ReadLine();
                Waiter waiter = waiters[random.Next(0, waiters.Count)];
                waiter.MakeOrder(order);
            }
        }
    }
}
