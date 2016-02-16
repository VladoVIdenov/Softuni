namespace Problem05ReverseNumber
{
    using System;
    using System.Security.AccessControl;

    public class ReverseNumbers
    {
        public static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();
            var result = ReverseNumber(numberAsString);
            Console.WriteLine(result);
        }

        private static double ReverseNumber(string numberAsString)
        {
            string reversed = string.Empty;

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                reversed += numberAsString[i];
            }

            double result = double.Parse(reversed, System.Globalization.CultureInfo.InvariantCulture);

            if (result % 1 == 0)
            {
                result = (int)result;
            }

            return result;
        }
    }
}
