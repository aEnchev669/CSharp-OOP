using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SportCar supra = new SportCar(700, 100);
            supra.Drive(100);
            Console.WriteLine(supra.HorsePower);
            Console.WriteLine(supra.Fuel);
            Console.WriteLine(supra.FuelConsumption);
        }
    }
}
