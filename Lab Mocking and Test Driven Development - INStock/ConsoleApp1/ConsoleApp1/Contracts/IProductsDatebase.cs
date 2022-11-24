using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion.Contracts
{
    public interface IProductsDatebase
    {
        public void Save(List<Product> products);

        public List<Product> GetAll();
    }
}
