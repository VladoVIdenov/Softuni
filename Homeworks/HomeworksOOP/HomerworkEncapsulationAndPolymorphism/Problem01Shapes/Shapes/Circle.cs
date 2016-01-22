using Problem01Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes.Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public double CalculatePerimeter()
        {
            return (2 * Math.PI * this.Radius);
        }
    }
}
