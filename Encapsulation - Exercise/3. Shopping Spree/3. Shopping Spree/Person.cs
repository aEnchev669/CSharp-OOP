using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Shopping_Spree
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        private double money;

        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        private List<BagOfProductss> bagOfProducts;

        public List<BagOfProductss> BagOfProducts
        {
            get { return bagOfProducts; }
            set { bagOfProducts = value; }
        }

        public Person(string name, double money, List<BagOfProductss> bag)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<BagOfProductss>(bag);
        }

        public void Buy(string name, string prouct)
        {
            

        }

    }
}
