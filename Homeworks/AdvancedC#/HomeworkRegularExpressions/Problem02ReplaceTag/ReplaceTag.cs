namespace Problem02ReplaceTag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            // Maybe this is not a valid solution but it works ....
            string input = Console.ReadLine();

            string result = string.Empty;
            List<string> output = new List<string>();

            while (input != string.Empty)
            {
                string pattern = @"<a";
                string replacement = @"[URL";

                Regex regex = new Regex(pattern);

                MatchCollection matches = regex.Matches(input);

                string removedOpenTags = regex.Replace(input, replacement, matches.Count);

                pattern = @"</a>";

                regex = new Regex(pattern);

                replacement = @"[/URL]";

                matches = regex.Matches(input);

                result = regex.Replace(removedOpenTags, replacement, matches.Count);
                output.Add(result);
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", output));
        }
    }
}
