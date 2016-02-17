namespace Problem03ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<string> emails = new List<string>();

            string pattern = @"(?!_)(\w+.)(\w+)@([A-Za-z0-9.-]+\.[a-zA-Z0-9_-]+)"; // WTF 

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine("{0}", match);
            }
        }
    }
}
