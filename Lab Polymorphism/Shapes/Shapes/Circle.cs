using ShapesWithPolymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.MathOperation
{
    public class Circle : Shape
    {

        public Circle(ConsoleColor color, Position position, int size) : base(color, position, size)
        {

        }

        public override void Draw()
        {
            double radius = Size;
            double rIn = radius - 0.4;
            double rOut = radius + 0.4;
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
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
