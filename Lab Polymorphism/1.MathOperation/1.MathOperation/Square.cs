using System;
using System.Collections.Generic;
using System.Text;

namespace _1.MathOperation
{
    public class Square
    {
        public Square(ConsoleColor color, int size, Position position)
        {
            Color = color;
            Size = size;
            Position = position;
        }

        public ConsoleColor Color { get; set; }
        public int Size { get; set; }
        public Position Position { get; set; }
        public void Draw()
        {
        }
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
    } 
}
