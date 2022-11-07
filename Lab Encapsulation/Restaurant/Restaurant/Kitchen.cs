using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public class Kitchen
    {
        private List<Ingredient> ingredients;
        public Kitchen(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }
        public void TakeOrder(Waiter waiter, string order, string specials)
        {
            switch (order)
            {
                case "Risotto": MakeRisotto(specials);
                    break;
                case "ChickenRise": MakeChickenRise(specials);
                    break;
                default:
                    UnknowmOrder();
                    break;
            }
            waiter.OrderReady(order);
        }

        private void UnknowmOrder()
        {
            Console.WriteLine("It's over!");
        }

        private void MakeChickenRise(string specials)
        {
            var onion = ingredients.First(o => o.Name == "Onion" && o.WeightInGrams > 100);
            var chiken = ingredients.First(o => o.Name == "Chicken" && o.WeightInGrams > 400);

            onion.WeightInGrams -= 100;
            chiken.WeightInGrams -= 400;

            Cook();

            Console.WriteLine("ChickenRise done!");
        }

        private void MakeRisotto(string specials)
        {
            var onion = ingredients.First(o => o.Name == "Onion" && o.WeightInGrams > 100);
            var tomatoe = ingredients.First(o => o.Name == "Tomatoe" && o.WeightInGrams > 200);
            var chiken = ingredients.First(o => o.Name == "Chicken" && o.WeightInGrams > 300);

            onion.WeightInGrams -= 100;
            tomatoe.WeightInGrams -= 200;
            chiken.WeightInGrams -= 300;

            Cook();

            Console.WriteLine("Risotto done!");
        }

        private void Cook()
        {
            Console.WriteLine("We are cooking for 30 minutes");
        }
    }
}
