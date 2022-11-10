using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class ICar
    {
        public ICar(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }
    }
}
