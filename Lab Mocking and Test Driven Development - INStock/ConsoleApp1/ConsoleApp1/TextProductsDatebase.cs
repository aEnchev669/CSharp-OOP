using ConsoleApp1;
using Newtonsoft.Json;
using Promotion.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Promotion
{
    public class TextProductsDatebase : IProductsDatebase
    {
        private string path;

        public TextProductsDatebase(string path)
        {
            this.path = path;
        }

        public List<Product> GetAll()
        {
            using(StreamReader reader = new StreamReader(path))
            {
                return JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());
            }
        }

        public void Save(List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(JsonConvert.SerializeObject(products, Formatting.Indented));
            }
        }
    }
}
