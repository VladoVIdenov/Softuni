namespace Problem03CountSubstringOccurrences
{
    using System;

    public class CountSubstrings
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();

            string temp = Console.ReadLine();

            int currentPossition = input.IndexOf(temp);

            int counter = 0;

            while (currentPossition >= 0 && currentPossition <= input.Length)
            {
                counter++;
                currentPossition = input.IndexOf(temp, currentPossition + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
