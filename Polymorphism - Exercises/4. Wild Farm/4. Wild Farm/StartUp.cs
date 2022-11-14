

namespace WildFarm
{
    using System;

    using Core;
    using Core.Interfaces;
    using Factories;
    using Factories.Interfaces;
    using IO;
    using IO.Inteface;
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IAnimalFactory animalFactory = new AnimalFactory();
            IFoodFactory foodFactory = new FoodFactory();

            IEngine engine = new Engine(reader,writer, animalFactory,foodFactory);

            engine.Run();
        }
    }
}
