namespace Problem05LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class LongestSequence
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            // In case of multiple spaces added.
            inputString = Regex.Replace(inputString, @"\s+", " ");

            List<int> intList = inputString.Split(' ').Select(int.Parse).ToList();

            int startIndex = 0;
            int lenght = 1;
            int bestStart = 0;
            int bestLenght = 1;

            for (int j = 1; j < intList.Count; j++)
            {
                if (intList[j] > intList[j - 1])
                {
                    lenght++;

                    if (bestStart <= startIndex && bestLenght < lenght)
                    {
                        bestStart = startIndex;
                        bestLenght = lenght;
                    }
                }
                else
                {
                    for (int k = startIndex; k < startIndex + lenght; k++)
                    {
                        Console.Write(intList[k] + " ");
                    }

                    startIndex = j;
                    lenght = 1;
                    Console.WriteLine();
                }
            }
            
            for (int i = startIndex; i < startIndex + lenght; i++)
            {
                Console.Write(intList[i] + " ");
            }

            Console.WriteLine();

            List<int> longestSequenceList = new List<int>();
            for (int i = bestStart; i < bestStart + bestLenght; i++)
            {
                longestSequenceList.Add(intList[i]);
            }

            Console.WriteLine("Longest: {0}", string.Join(" ", longestSequenceList));
        }
    }
}
