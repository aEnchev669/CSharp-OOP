using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Exceptions;
using WildFarm.Factories.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Intefaces;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
       
    
        public IAnimal CreateAnimal(string[] cmdArgs)
        {
            //TODO: Use reflection
            string type = cmdArgs[0];
            string name = cmdArgs[1];
            double weight = double.Parse(cmdArgs[2]);
            string fourthArg = cmdArgs[3];

            IAnimal animal;
            if (type == "Owl")
            {
                animal = new Owl(name, weight, double.Parse(fourthArg));
            }
            else if (type == "Hen")
            {
                animal = new Hen(name, weight, double.Parse(fourthArg));
            }
            else if (type == "Mouse")
            {
                animal = new Mouse(name, weight, fourthArg);
            }
            else if (type == "Dog")
            {
                animal = new Dog(name, weight, fourthArg);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, weight, fourthArg, cmdArgs[4]);
            }
            else if (type == "Tiger")
            {
                animal = new Tiger(name, weight, fourthArg, cmdArgs[4]);
            }
            else
            {
                throw new InvalidAnimalTypeException();
            }

            return animal;
        }
    }
}
