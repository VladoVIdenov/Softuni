namespace Problem01SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(\w)\1+";
            Regex regex = new Regex(pattern);

            string replacement = "$1"; // return capturing group

            MatchCollection matches = regex.Matches(input);

            string result = regex.Replace(input, replacement, matches.Count);
            Console.WriteLine(result);
        }
    }
}
