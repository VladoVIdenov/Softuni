using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEncapsulationPolymorphism01
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);

            Rectangle rect = new Rectangle(3, 4);

            Figure[] figures = new Figure[]
            {
                new Circle(3),
                new Rectangle(3, 4),
                new Circle(4),
                new Rectangle(4, 8),
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.CalculateSurface());
            }
        }
    }
}
