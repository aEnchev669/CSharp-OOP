using System;

namespace Ex___Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawer drawer = new ConsoleDrawer();

            drawer.WriteLine("Hello22");
            drawer.Write("Hello");
            drawer.WriteLineAtPosition(5, 30, "Hello at middle");
           
            Circle circle = new Circle();
            circle.Draw();

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

        }
    }
}
