namespace Problem02PerformanceOperation
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class MainProgram
    {
        private const int NumberOfOperations = 1000000;

        private const int IntFirstNumber = 1;

        private const int IntSecondNumber = 10;

        private const long LongFirstNumber = 1L;

        private const long LongSecondNumber = 10L;

        private const double DoubleFirstNumber = 1.0;

        private const double DoubleSecondNumber = 10.0;

        private const decimal DecimalFirstNumber = 1M;

        private const decimal DecimalSecondNumber = 10M;

        public static void Main()
        {
            Console.WriteLine("Addition:");

            Stopwatch stopwatch = new Stopwatch();
            AdditionInt();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Int", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            AdditionLong();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Long", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            AdditionDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            AdditionDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Substract: ");

            stopwatch.Start();
            SubstractInt();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Int", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            SubstractLong();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Long", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            SubstractDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            SubstractDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Increment Prefix:");

            stopwatch.Start();
            IncrementPrefixInt();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Int", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementPrefixLong();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Long", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementPrefixDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementPrefixDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Increment Postfix:");

            stopwatch.Start();
            IncrementPostfixInt();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Int", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementPostfixLong();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Long", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementPostfixDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementPostfixDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Addition With One:");

            stopwatch.Start();

            stopwatch.Start();
            AdditionWithOneInt();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Int", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            AdditionWithOneLong();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Long", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            AdditionWithOneDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            AdditionWithOneDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Multiply");

            stopwatch.Start();
            MultiplyInt();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Int", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            MultiplyLong();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Long", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            MultiplyDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            MultiplyDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Divide");

            stopwatch.Start();
            DivideInt();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Int", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            DivideLong();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Long", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            DivideDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            DivideDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("MathSqrt");

            stopwatch.Start();
            MathSqurtDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            MathSqurtDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("MathLog");

            stopwatch.Start();
            MathLogDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            MathLogDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("MathSin");

            stopwatch.Start();
            MathSinDouble();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Double", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            MathSinDecimal();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} ms Decimal", stopwatch.ElapsedMilliseconds);
        }

        private static void AdditionInt()
        {
            int result; 

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = IntFirstNumber + IntSecondNumber;
            }
        }

        private static void AdditionLong()
        {
            long result;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = LongFirstNumber + LongSecondNumber;
            }
        }

        private static void AdditionDouble()
        {
            double result;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = DoubleFirstNumber + DoubleSecondNumber;
            }
        }

        private static void AdditionDecimal()
        {
            decimal result;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = DecimalFirstNumber + DecimalSecondNumber;
            }
        }

        private static void SubstractInt()
        {
            int result;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = IntFirstNumber - IntSecondNumber;
            }
        }

        private static void SubstractLong()
        {
            long result;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = LongFirstNumber - LongSecondNumber;
            }
        }

        private static void SubstractDouble()
        {
            double result;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = DoubleFirstNumber  - DoubleSecondNumber;
            }
        }

        private static void SubstractDecimal()
        {
            decimal result;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = DecimalFirstNumber - DecimalSecondNumber;
            }
        }

        private static void IncrementPrefixInt()
        {
            int result = 0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                ++result;
            }
        }

        private static void IncrementPrefixLong()
        {
            long result = 0L;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                ++result;
            }
        }

        private static void IncrementPrefixDouble()
        {
            double result = 0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                ++result;
            }
        }

        private static void IncrementPrefixDecimal()
        {
            decimal result = 0L;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                ++result;
            }
        }

        private static void IncrementPostfixInt()
        {
            int result = 0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result++;
            }
        }

        private static void IncrementPostfixLong()
        {
            long result = 0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result++;
            }
        }

        private static void IncrementPostfixDouble()
        {
            double result = 0.0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result++;
            }
        }

        private static void IncrementPostfixDecimal()
        {
            decimal result = 0M;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result++;
            }
        }

        private static void AdditionWithOneInt()
        {
            int result = 0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result += 1;
            }
        }

        private static void AdditionWithOneLong()
        {
            long result = 0L;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result += 1;
            }
        }

        private static void AdditionWithOneDouble()
        {
            double result = 0.0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result += 1;
            }
        }

        private static void AdditionWithOneDecimal()
        {
            decimal result = 0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result += 1;
            }
        }

        private static void MultiplyInt()
        {
            int result = 0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = IntFirstNumber * IntSecondNumber;
            }
        }

        private static void MultiplyLong()
        {
            long result = 0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = LongFirstNumber * LongSecondNumber;
            }
        }

        private static void MultiplyDouble()
        {
            double result = 0.0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = DoubleFirstNumber * DoubleSecondNumber;
            }
        }

        private static void MultiplyDecimal()
        {
            decimal result = 0M;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = DecimalFirstNumber * DecimalSecondNumber;
            }
        }

        private static void DivideInt()
        {
            int result = 0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = IntFirstNumber / IntSecondNumber;
            }
        }

        private static void DivideLong()
        {
            long result = 0L;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = LongFirstNumber / LongSecondNumber;
            }
        }

        private static void DivideDouble()
        {
            double result = 0.0;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = DoubleFirstNumber / DoubleSecondNumber;
            }
        }

        private static void DivideDecimal()
        {
            decimal result = 0M;

            for (int i = 0; i < NumberOfOperations; i++)
            {
                result = DecimalFirstNumber / DecimalSecondNumber;
            }
        }

        private static void MathSqurtDouble()
        {
            for (int i = 0; i < NumberOfOperations; i++)
            {
                Math.Sqrt(DoubleSecondNumber);
            }
        }

        private static void MathSqurtDecimal()
        {
            for (int i = 0; i < NumberOfOperations; i++)
            {
                Math.Sqrt((double)DecimalSecondNumber);
            }
        }

        private static void MathLogDouble()
        {
            for (int i = 0; i < NumberOfOperations; i++)
            {
                Math.Log(DoubleSecondNumber, Math.E);
            }
        }

        private static void MathLogDecimal()
        {
            for (int i = 0; i < NumberOfOperations; i++)
            {
                Math.Log((double)DecimalSecondNumber, Math.E);
            }
        }

        private static void MathSinDouble()
        {
            for (int i = 0; i < NumberOfOperations; i++)
            {
                Math.Sin(DoubleSecondNumber);
            }
        }

        private static void MathSinDecimal()
        {
            for (int i = 0; i < NumberOfOperations; i++)
            {
                Math.Sin((double)DecimalSecondNumber);
            }
        }
    }
}
