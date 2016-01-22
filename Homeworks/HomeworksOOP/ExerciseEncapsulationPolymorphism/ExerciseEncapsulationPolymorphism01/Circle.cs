using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEncapsulationPolymorphism01
{
    class Circle : Figure
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public override double CalculateSurface()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
