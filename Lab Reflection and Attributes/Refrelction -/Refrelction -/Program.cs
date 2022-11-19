using System;
using System.Collections.Generic;
using System.Reflection;

namespace Refrelction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Studnet studnet = new Studnet() { Name = "Gosho", Age = 12, Score = 100 };
            PrintProperties(studnet);
        }

        public static void PrintProperties(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.Name} : {property.GetValue(obj)}");

            }
        }
        class Studnet
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Score { get; set; }
            public Studnet Friend { get; set; }
        }
    }
}
