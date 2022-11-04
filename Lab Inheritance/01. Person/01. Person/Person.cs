using System;
using System.Text;

namespace _01._Person
{
    public class Person
    {
        private string name;

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
           

            return $"Name: {Name}, Age: {Age}";
        }

    }
}
