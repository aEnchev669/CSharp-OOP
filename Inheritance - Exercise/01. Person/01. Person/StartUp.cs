using System;

namespace _01._Person
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age > 0 && age > 15)
            {
                Person person = new Person(name, age);
                Console.WriteLine(person);
            }
            else if (age > 0 && age < 15)
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
        }
    }
}
