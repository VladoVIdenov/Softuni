namespace Problem06Palindromes
{
    using System;
    using System.Collections.Generic;

    public class Palidromes
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] stringArr = input.Trim().Split(new char[] { ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> result = new SortedSet<string>();

            for (int i = 0; i < stringArr.Length; i++)
            {
                string reversed = ReverseString(stringArr[i]);
                if (stringArr[i] == reversed)
                {
                    result.Add(stringArr[i]);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }

        public static string ReverseString(string input)
        {
            char[] stringTochar = input.ToCharArray();
            Array.Reverse(stringTochar);
            return new string(stringTochar);
        }
    }
}
