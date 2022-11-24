using System;
using System.Collections.Generic;
using System.Text;

namespace Moq
{
    public interface IDatebase
    {
        public void Save();
        public void Update();
        public void Delete ();
    }
}
