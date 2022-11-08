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
                try
                {
                    string[] input = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                    persons.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            

           
         

            Team team = new Team("SoftUni");

            foreach (Person person in persons)

            {
                team.AddPlayer(person);
            }

            Console.WriteLine(team);
        }
    }
}
