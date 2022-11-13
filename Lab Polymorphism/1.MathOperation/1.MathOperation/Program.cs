using System;

namespace _1.MathOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write($"Shape: ");
                string shape = Console.ReadLine();

                Console.Write($"Size: ");
                int size = int.Parse(Console.ReadLine());

                Console.Write($"Row: ");
                int row = int.Parse(Console.ReadLine());

                Console.Write($"Col: ");
                int col = int.Parse(Console.ReadLine());

                Console.Write($"Color: ");
                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine());
                Console.WriteLine();

                if (shape == "Circle")
                {
                    Circle circle = new Circle(color, size, new Position(row, col));

                    circle.SetStartPosition();
                    circle.ChangeColor(color);
                    circle.Draw();
                    circle.ResetColor();

                }
                else if (shape == "Square")
                {
                    Square square = new Square(color, size, new Position(row, col));

                    square.SetStartPosition();
                    square.ChangeColor(color);
                    square.Draw();
                    square.ResetColor();

                }
            }
        }
    }
}
