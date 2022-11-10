using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IPrintable
    {
        void Print(int x, object y = null);

        public int Size { get; set; }
    }
}
