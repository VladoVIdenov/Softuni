using System;

namespace Problem01SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number for Square Root: ");
                int numberToSqrt = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(numberToSqrt);
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
            
        }
    }
}
