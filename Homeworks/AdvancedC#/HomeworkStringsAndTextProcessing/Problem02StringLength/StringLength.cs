namespace Problem02StringLength
{
    using System;
    using System.Text;

    public class StringLength
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder(0, 20);

            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[i]);
                if (i == result.MaxCapacity)
                {
                    break;
                }
            }

            if (result.MaxCapacity - input.Length > 0)
            {
                string asterix = new string('*', result.MaxCapacity - input.Length);
                result.Append(asterix);
            }

            Console.WriteLine(result);
        }
    }
}
