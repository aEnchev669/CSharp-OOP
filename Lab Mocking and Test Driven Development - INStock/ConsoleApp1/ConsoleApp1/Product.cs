using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Product
    {
        public Product(int iD, string name, decimal price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id: {ID} -- {Name} : {Price}";
        }
    }
}
