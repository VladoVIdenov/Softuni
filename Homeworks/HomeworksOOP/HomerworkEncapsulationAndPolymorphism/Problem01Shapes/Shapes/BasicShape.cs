using Problem01Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes.Shapes
{
    abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Width cannot be negative");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Height cannot be negative");
                }
                this.height = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
