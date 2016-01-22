namespace Abstraction
{
    using System;

    public class FiguresExample
    {
        public static void Main()
        {
            try
            {
                Circle circle = new Circle(5);

                Console.WriteLine(
                    "I am a Circle. " + "My perimeter is {0:f2}. My surface is {1:f2}.",
                    circle.CalcPerimeter(), 
                    circle.CalcSurface());

                Rectangle rectangle = new Rectangle(-2, 3);

                Console.WriteLine(
                    "I am a Rectangle. " + "My perimeter is {0:f2}. My surface is {1:f2}.",
                    rectangle.CalcPerimeter(),
                    rectangle.CalcSurface());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("GoobBye");
            }
        }
    }
}
