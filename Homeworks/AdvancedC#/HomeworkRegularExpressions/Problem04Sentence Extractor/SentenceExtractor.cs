namespace Problem04Sentence_Extractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main()
        {
            // No idea if this is valid solution
            string keyword = Console.ReadLine();

            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b[\w\s,`()'-]+[.!?]");

            MatchCollection matches = regex.Matches(input);

            keyword = " " + keyword + " ";

            foreach (Match match in matches)
            {
                if (match.ToString().Contains(keyword))
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
