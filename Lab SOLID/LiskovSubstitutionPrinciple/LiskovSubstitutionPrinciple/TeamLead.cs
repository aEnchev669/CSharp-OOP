using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class TeamLead : IWorker, IEmployee
    {
        public void GetPaid()
        {
            Console.WriteLine("Getting paid");
        }

        public void Sleep()
        {
            Console.WriteLine("Getting sleep");

        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
}
