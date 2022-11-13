using System;
using System.Collections.Generic;
using System.Text;

namespace _1.MathOperation
{
    public class Circle
    {
        public Circle(ConsoleColor color, int size, Position position)
        {
            Color = color;
            Size = size;
            Position = position;
        }

        public ConsoleColor Color { get; set; }
        public int Size { get; set; }
        public Position Position { get; set; }
        public void ChangeColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.ForegroundColor = color;
        }
        public void ResetColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SetStartPosition()
        {
            Console.SetCursorPosition(Position.Left, Position.Top);
        }
        public void Draw()
        {
            double radius = Size;
            double rIn = radius - 0.4; 
            double rOut = radius + 0.4;
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = - radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
