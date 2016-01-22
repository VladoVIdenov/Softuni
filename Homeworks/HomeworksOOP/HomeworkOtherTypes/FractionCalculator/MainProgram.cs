
using System;


class MainProgram
{
    static void Main()
    {
        Fraction fract1 = new Fraction(22, 7);
        Fraction fract2 = new Fraction(40, 4);
        Fraction result = (double)fract1 + fract2;
        Fraction result2 = (double)fract1 - fract2;
    
        Console.WriteLine("result {0} + {1} = {2}", fract1, fract2 , (double)result);
        Console.WriteLine("result {0} - {1} = {2}", fract1, fract2, (double)result2);
        Console.WriteLine(result);
    }
}

