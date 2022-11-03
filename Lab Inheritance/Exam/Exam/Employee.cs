using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    internal class Employee
    {
        public decimal Salary { get; set; }
        public string Name { get; set; }
        public int HappinnesLevel { get; set; }

        public void GetPaid()
        {
            HappinnesLevel += 10;
            Console.WriteLine($"Yooho");
        }
    }
}
