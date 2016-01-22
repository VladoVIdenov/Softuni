using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEncapsulationPolymorphism01
{
    public class Rectangle : Figure
    {
        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public double SideA { get; set; }
        public double SideB { get; set; }


        public override double CalculateSurface()
        {
            return this.SideA * this.SideB;
        }
    }
}
