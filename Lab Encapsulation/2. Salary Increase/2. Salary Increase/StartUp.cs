using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < countOfPeople; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                persons.Add(person);
            }
            var parcentage = decimal.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
