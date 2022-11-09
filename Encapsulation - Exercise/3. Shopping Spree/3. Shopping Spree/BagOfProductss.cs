using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Shopping_Spree
{
    public class BagOfProductss
    {
        private string name;
        private double cost;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == " ")
                {
                    throw new AggregateException("Name cannot be empty");
                }
                name = value;
            }
        }
        public double Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
        }


    }
}
