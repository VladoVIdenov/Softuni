namespace Problem02LastDigitOfNumber
{
    using System;

    public class LastDigitAsWord
    {
        public static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintLastDigitAsWord(numberToCheck));
        }

        public static string PrintLastDigitAsWord(int number)
        {
            string[] numbersAsWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int digit = number % 10;

            return numbersAsWords[digit];
        }
    }
}
