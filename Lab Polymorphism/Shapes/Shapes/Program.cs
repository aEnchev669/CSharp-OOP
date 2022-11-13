using ShapesWithPolymorphism;
using System;

namespace _1.MathOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {


                Console.Write($"Size: ");
                int size = int.Parse(Console.ReadLine());

                Console.Write($"Row: ");
                int row = int.Parse(Console.ReadLine());

                Console.Write($"Col: ");
                int col = int.Parse(Console.ReadLine());

                Console.Write($"Color: ");
                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine());
                Console.WriteLine();

                while (true)
                {
                    string input = Console.ReadLine();

                    Shape shape = null;
                    if (input == "Circle")
                    {
                        shape = new Circle(color, new Position(row, col), size);



                    }
                    else if (input == "Square")
                    {
                        shape = new Square(color, new Position(row, col), size);

                    }
                    shape.ChangeColor(color);
                    shape.SetStartPosition();
                    shape.Draw();
                    shape.ResetColor();

                }
            }
        }
    }
}
