using System;
using System.Collections.Generic;
using System.Text;

namespace BoxEx
{
    public class Box
    {
        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }
        private double length;

        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        private double width;

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        private double height;

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }



        public double SurfaceArea() => (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

        public double LateralSurfaceArea() => (2 * this.Height * this.Width) + (2 * this.Length * this.Height);

        public double Volume() => this.Width * this.Height * this.Length;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
               .AppendLine($"Surface Area - {this.SurfaceArea():f2}")
               .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}")
               .AppendLine($"Volume - {this.Volume():f2}");

            return sb.ToString().Trim();
        }

    }
}
