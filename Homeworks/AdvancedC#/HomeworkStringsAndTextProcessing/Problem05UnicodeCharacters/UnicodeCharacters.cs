namespace Problem05UnicodeCharacters
{
    using System;
    using System.Text;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            foreach (char ch in input)
            {
                result.Append("\\u");
                result.Append(string.Format("{0:x4}", (int)ch));
            }

            Console.WriteLine(result);
        }
    }
}
