using System;
using System.Collections.Generic;
using System.Text;

namespace Ex___Abstraction
{
    public interface IDrawer
    {
        public void WriteLine(string text);
        public void Write(string text);
        public void WriteLineAtPosition(int col, int row, string text);
    }
}
