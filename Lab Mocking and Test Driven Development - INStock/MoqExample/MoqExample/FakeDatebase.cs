using System;
using System.Collections.Generic;
using System.Text;

namespace Moq
{
    public class FakeDatebase : IDatebase
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
