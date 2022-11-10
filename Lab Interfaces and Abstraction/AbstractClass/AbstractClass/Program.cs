using System;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseShape shape = new Circle();

            shape.Top = 2;
            shape.Left = 12;
        }
    }
}
