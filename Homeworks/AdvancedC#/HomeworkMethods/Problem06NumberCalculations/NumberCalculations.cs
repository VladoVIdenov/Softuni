namespace Problem06NumberCalculations
{
    using System;

    public class NumberCalculations
    {
        public static void Main()
        {
            double[] doubleArr = { 2.3, 4.56, 99, 89.4, 2.12, 0.99 };
            decimal[] decimalArr = { 1, 5, 99, 669987, 45, 32, 1 };
            
            Console.WriteLine(Sum(doubleArr));
            Console.WriteLine(Sum(decimalArr));
            Console.WriteLine(GetMin(doubleArr));
            Console.WriteLine(GetMin(decimalArr));
            Console.WriteLine(GetMax(doubleArr));
            Console.WriteLine(GetMax(decimalArr));
            Console.WriteLine(Average(doubleArr));
            Console.WriteLine(Average(decimalArr));
            Console.WriteLine(Product(doubleArr));
            Console.WriteLine(Product(decimalArr));
        }

        // Product
        public static decimal Product(decimal[] decimalArr)
        {
            decimal result = 1;

            for (int i = 0; i < decimalArr.Length; i++)
            {
                result *= decimalArr[i];
            }

            return result;
        }

        public static double Product(double[] doubleArr)
        {
            double result = 1;

            for (int i = 0; i < doubleArr.Length; i++)
            {
                result *= doubleArr[i];
            }

            return result;
        }

        // Average
        public static decimal Average(decimal[] decimalArr)
        {
            decimal average = Sum(decimalArr) / decimalArr.Length;

            return average;
        }

        public static double Average(double[] doubleArr)
        {
            double average = Sum(doubleArr) / doubleArr.Length;

            return average;
        }

        // Max
        public static decimal GetMax(decimal[] decimalArr)
        {
            decimal maxValue = decimal.MinValue;

            for (int i = 0; i < decimalArr.Length; i++)
            {
                if (decimalArr[i] > maxValue)
                {
                    maxValue = decimalArr[i];
                }
            }

            return maxValue;
        }

        public static double GetMax(double[] doubleArr)
        {
            double maxValue = double.MinValue;

            for (int i = 0; i < doubleArr.Length; i++)
            {
                if (doubleArr[i] > maxValue)
                {
                    maxValue = doubleArr[i];
                }
            }

            return maxValue;
        }

        // Min
        public static double GetMin(double[] doubleArr)
        {
            double minValue = double.MaxValue;

            for (int i = 0; i < doubleArr.Length; i++)
            {
                if (doubleArr[i] < minValue)
                {
                    minValue = doubleArr[i];
                }
            }

            return minValue;
        }

        public static decimal GetMin(decimal[] decimalArr)
        {
            decimal minValue = decimal.MaxValue;

            for (int i = 0; i < decimalArr.Length; i++)
            {
                if (decimalArr[i] < minValue)
                {
                    minValue = decimalArr[i];
                }
            }

            return minValue;
        }

        // Sum
        public static double Sum(double[] doubleArr)
        {
            double result = 0;

            for (int i = 0; i < doubleArr.Length; i++)
            {
                result += doubleArr[i];
            }

            return result;
        }

        public static decimal Sum(decimal[] decimalArr)
        {
            decimal result = 0;

            for (int i = 0; i < decimalArr.Length; i++)
            {
                result += decimalArr[i];
            }

            return result;
        }
    }
}
