using System;
using System.Collections.Generic;
using System.Text;

namespace Ex___Abstraction
{
    public class Rectangle
    {
        public void Draw()
        {
            int arg1 = 5;
            int arg2 = 10;
            
            
            for (int row = 1; row <= arg1; row++)
            {

                if (row == 1 || row == arg1)
                {
                    for (int col = 1; col <= arg2; col++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                if (row < arg1 && row < arg1 - 1)
                {
                    Console.Write("*");
                    for (int i = 0; i < arg2 - 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
    }
}
