using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Document : BaseDocument , I3DPrintable
    {
        public int ZSize { get; set; }
        public int Size { get; set; }

        public void Print(int x, object y = null)
        {
            throw new NotImplementedException();
        }
        public int PaperSIze{ get; set; }
    }
}
