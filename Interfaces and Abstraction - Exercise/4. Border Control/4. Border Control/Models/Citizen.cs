﻿


namespace BorderControl.Models
{
    using Interfaces;
    using Validation;

    public class Citizen : ICitizen
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        
    }
}
