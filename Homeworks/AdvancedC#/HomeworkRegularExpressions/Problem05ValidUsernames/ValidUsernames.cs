namespace Problem05ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\b[a-zA-Z][\w]{2,24}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            List<string> validUsernames = (from Match match in matches select match.ToString()).ToList();

            int bestSum = 0;
            int bestIndex = 0;

            for (int i = 1; i < validUsernames.Count; i++)
            {
                if (validUsernames[i].Length + validUsernames[i - 1].Length > bestSum)
                {
                    bestSum = validUsernames[i].Length + validUsernames[i - 1].Length;
                    bestIndex = i - 1;
                }
            }

            Console.WriteLine(validUsernames[bestIndex]);
            Console.WriteLine(validUsernames[bestIndex + 1]);

            // judje 100 
        }
    }
}
