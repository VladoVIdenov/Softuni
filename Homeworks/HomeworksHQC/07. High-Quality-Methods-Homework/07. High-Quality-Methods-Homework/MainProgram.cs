namespace Methods
{
    using System;

    public class MainProgram
    {
        internal static void Main()
        {
            Console.WriteLine(Calculator.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Formater.ConvertNumberToDigit(9));

            Console.WriteLine(Calculator.FindMax(50.2, -1, 3, 2, 14, 2, 3));

            Formater.FormatNumber(1.3, "f");
            Formater.FormatNumber(0.75, "%");
            Formater.FormatNumber(2.30, "r");

            double pointOneX = 4.5;
            double pointOneY = 4.5;
            double pointTwoX = 1;
            double pointTwoY = 4.5;

            Console.WriteLine("Distance: {0}", Calculator.CalculateDistance(pointOneX, pointOneY, pointTwoX, pointTwoY));
            Console.WriteLine("Horizontal? " + Calculator.CheckIsHorizontal(pointOneY, pointTwoY));
            Console.WriteLine("Vertical? " +  Calculator.CheckIsVertical(pointOneX, pointTwoX));

            Student peter = new Student()
            {
                FirstName = "Peter",
                LastName = "Ivanov"
            };

            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student()
            {
                FirstName = "Stella",
                LastName = "Markova"
            };

            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
