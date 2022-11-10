using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface I3DPrintable : IPrintable
    {
        public int ZSize { get; set; }
    }
}
