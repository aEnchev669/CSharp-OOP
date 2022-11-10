using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public override string ToString()
        {
            return $"{Color} Seat {Model}";
        }
    }
}
