using System;
using System.Collections.Generic;
using System.Text;

public class Exceptions
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (count > (arr.Length - startIndex))
        {
            throw new ArgumentOutOfRangeException("The desired number of symbols is greater than remaining in the array");
        }
        else if (count > arr.Length)
        {
            throw new ArgumentOutOfRangeException("The desired number of symbols is greater than length of the array");
        }
        else if (startIndex > arr.Length)
        {
            throw new ArgumentOutOfRangeException("The starting index is larger than array length");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("Count", "The count cannot be larger than string's length");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("The count cannot be negative");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                throw new InvalidOperationException("The number is not prime!");
            }
        }
    }

    public static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        ////Console.WriteLine(ExtractEnding("Hi", 100));

        int numberForCheck = 45; // Change the number

        try
        {
            CheckPrime(numberForCheck);
            Console.WriteLine("{0} is prime", numberForCheck);
        }
        catch (Exception ex)
        {
            Console.WriteLine("{0} : {1}", numberForCheck, ex.Message);
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
