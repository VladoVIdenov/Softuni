namespace Problem04SequencesOfEqualStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SequenceOfStrings
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            // In case of multiple spaces added.
            inputString = Regex.Replace(inputString, @"\s+", " ");

            List<string> stringList = inputString.Split(' ').ToList();

            Console.Write(stringList[0]);

            for (int i = 1; i < stringList.Count; i++)
            {
                if (stringList[i].Equals(stringList[i - 1]))
                {
                    Console.Write(" " + stringList[i]);
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(stringList[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
