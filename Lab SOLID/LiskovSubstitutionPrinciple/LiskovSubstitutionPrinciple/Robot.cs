using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine($"I ma robot and im working");
        }
    }
}
