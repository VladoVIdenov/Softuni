namespace Problem06SubsetSums
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int sumNumber = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (sumNumber == 0)
            {
                Console.WriteLine("0");
            }

            
        }
    }
}
