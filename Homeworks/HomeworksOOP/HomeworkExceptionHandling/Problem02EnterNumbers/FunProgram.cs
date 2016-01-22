using System;

namespace Problem02EnterNumbers
{
    public class FunProgram
    {

        static void Main()
        {
            int start = 1;
            int end = 100;
            int counter = 0;
            int decreasedCounter = 10; // counter may be used too for this.

            Console.WriteLine("Please enter numbers 10 times");
            while (counter < 10 && decreasedCounter != 0)
            {
                if (counter < 10 && start == 99)
                {
                    Console.WriteLine("You did not enter numbers requred times.");
                    break;
                }
                start = ReadNumbers(start, end);
                counter++;
                decreasedCounter--;
                if (decreasedCounter == 0 )
                {
                    break;
                }
            }
        }
        static int ReadNumbers(int start, int end)
        {
            int userNumber;
            try
            {
                Console.Write("Enter number in range [ {0} < .... < {1} ]  : ", start, end);
               
                userNumber = int.Parse(Console.ReadLine());
                
                if (userNumber <= start || userNumber >= end)
                {
                    while ((userNumber <= start || userNumber >= end))
                    {
                        Console.Write("PLease enter a valid number in range [ {0} < .... < {1} ] : ",
                            start, end);
                        userNumber = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                throw;
            }
            return userNumber;
        }
    }
}
