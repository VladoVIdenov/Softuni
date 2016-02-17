namespace Problem01ReverseString
{
    using System;
    using System.Text;

    public class ReverseStringMain
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var reversedString = ReverseString(input);

            Console.WriteLine(reversedString);
        }

        public static StringBuilder ReverseString(string input)
        {
            StringBuilder reversedString = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString.Append(input[i]);
            }

            return reversedString;
        }
    }
}
