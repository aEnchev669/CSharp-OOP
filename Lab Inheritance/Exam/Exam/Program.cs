 using System;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            Programmer programmer = new Programmer();
            programmer.GetPaid();
            programmer.GetPaid();
            Console.WriteLine(programmer.HappinnesLevel);

            TeamLeader leader = new TeamLeader();

            leader.Salary = 100;
            leader.Name = "Gosho";

            leader.GetPaid();
            Console.WriteLine(leader.HappinnesLevel);

            leader.FixBugs();

        }
    }
}
