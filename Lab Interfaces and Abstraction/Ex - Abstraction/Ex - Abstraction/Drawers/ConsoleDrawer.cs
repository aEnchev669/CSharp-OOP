using System;
using System.Collections.Generic;
using System.Text;

namespace Ex___Abstraction.Drawers
{
    public class ConsoleDrawer : IDrawer
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteLineAtPosition(int col, int row, string text)
        {
            Console.SetCursorPosition(row, col);
            Write(text);
        }
    }
}
