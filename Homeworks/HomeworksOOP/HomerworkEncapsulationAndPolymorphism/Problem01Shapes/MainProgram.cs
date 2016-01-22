using Problem01Shapes.Interfaces;
using Problem01Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Rhombus(4, 6),
                new Rectangle(5,20),
                new Circle(17.5)
            };
            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculatePerimeter());
            }
        }
    }
}
