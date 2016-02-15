namespace Problem06CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class CountSymbols
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            var dict = new SortedDictionary<char, int>();

            foreach (var letter in inputString)
            {
                var count = 1;
                if (dict.TryGetValue(letter, out count))
                {
                    dict[letter] = count + 1;
                }
                else
                {
                    dict.Add(letter, 1);
                }
            }

            foreach (KeyValuePair<char, int> key in dict)
            {
                Console.WriteLine("{0}: {1} time/s", key.Key, key.Value);
            }
        }
    }
}
