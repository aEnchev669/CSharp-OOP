using _1.MathOperation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesWithPolymorphism
{
    public abstract class Shape
    {
       
        protected Shape(ConsoleColor color, Position position, int size)
        {
            Color = color;
            Position = position;
            Size = size;
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
        public abstract void Draw();
    }
}
