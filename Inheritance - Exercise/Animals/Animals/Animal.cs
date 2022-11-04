﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;


       
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Invalid input!");
                else
                {
                    name = value;

                }
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value <= 0) throw new ArgumentException("Invalid input!");
                else
                {
                    age = value;

                }
            }
        }

        public string Gender
        {
            get { return gender; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Invalid input!");
                else
                {

                    gender = value;
                }
            }
        }
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public virtual string ProduceSound() => "Noise";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetType().Name}")
                .AppendLine($"{Name} {Age} {Gender}")
                .AppendLine(ProduceSound());

            return sb.ToString();
        }
    }
}
