using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    internal class Programmer : Employee
    {
        

        public void CreateBugs()
        {
            Console.WriteLine($"I'm only creating bugs all day");
        }
    }
}
