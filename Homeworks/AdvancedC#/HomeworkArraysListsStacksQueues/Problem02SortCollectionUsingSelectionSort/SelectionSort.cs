namespace Problem02SortCollectionUsingSelectionSort
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SelectionSort
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            // In case of multiple spaces added.
            inputString = Regex.Replace(inputString, @"\s+", " ");

            // Again array needed by condition of the task
            int[] myArray = inputString.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int indexOfNewMin = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[indexOfNewMin])
                    {
                        // Store the index of new minimum value
                        indexOfNewMin = j;
                    }
                }

                if (indexOfNewMin != i)
                {
                    int bufferNumber = 0;
                    bufferNumber = myArray[indexOfNewMin];
                    myArray[indexOfNewMin] = myArray[i];
                    myArray[i] = bufferNumber;
                }
            }

            Console.WriteLine(string.Join(" ", myArray));
        }
    }
}
