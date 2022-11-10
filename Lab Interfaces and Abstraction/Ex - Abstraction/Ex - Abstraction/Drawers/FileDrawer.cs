using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ex___Abstraction
{
    public class FileDrawer : IDrawer
    {
        private string path;

        public FileDrawer(string path)
        {
            this.path = path;
        }
        public void Write(string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(text);
            }
        }

        public void WriteLine(string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(text);
            }
        }

        public void WriteLineAtPosition(int col, int row, string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(text);
            }
        }
    }
}
