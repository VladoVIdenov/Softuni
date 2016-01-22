using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes.Shapes
{
    class Rhombus : BasicShape
    {
        public Rhombus(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return (2 * this.Width) + (2 * Height);
        }
    }
}
