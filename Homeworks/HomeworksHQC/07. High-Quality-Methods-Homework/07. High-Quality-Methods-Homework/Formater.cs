namespace Methods
{
    using System;

    public static class Formater
    {
        /// <summary>
        /// Convert a number to string within range [ 0 ... 9 ]
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ConvertNumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new ArgumentOutOfRangeException("Number", "The number must be in Range [ 0 ... 9 ]");
            }
        }

        /// <summary>
        /// Print number in specific format
        /// </summary>
        /// <param name="number"></param>
        /// <param name="format"> f, </param>
        public static void FormatNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new FormatException("Invalid Format");
            }
        }
    }
}
