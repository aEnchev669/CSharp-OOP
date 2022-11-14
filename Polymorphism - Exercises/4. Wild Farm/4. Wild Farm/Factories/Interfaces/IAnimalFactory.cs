using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Intefaces;

namespace WildFarm.Factories.Interfaces
{
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(string[] cmdArgs);
    }
}
