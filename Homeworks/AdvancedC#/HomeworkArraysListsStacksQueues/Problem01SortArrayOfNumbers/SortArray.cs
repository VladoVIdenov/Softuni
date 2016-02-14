namespace Problem01SortArrayOfNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SortArray
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            // In case of multiple spaces added.
            inputString = Regex.Replace(inputString, @"\s+", " ");

            // Array needed by condition of the task.
            int[] intArray = inputString.Split(' ').Select(int.Parse).ToArray();

            Array.Sort(intArray);

            Console.WriteLine(string.Join(" ", intArray));
        }
    }
}
