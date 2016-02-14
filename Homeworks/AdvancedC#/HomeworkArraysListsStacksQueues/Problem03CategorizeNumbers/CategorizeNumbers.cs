namespace Problem03CategorizeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class CategorizeNumbers
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            // In case of multiple spaces added.
            inputString = Regex.Replace(inputString, @"\s+", " ");

            List<string> stringList = inputString.Split(' ').ToList();
            List<double> listOfFloats = new List<double>();
            List<int> listOfInts = new List<int>();

            // first all integers add ind separate list and all others to list with floats.
            foreach (var str in stringList)
            {
                double floatNumber = 0;
                int intNumber = 0;
                if (int.TryParse(str, out intNumber))
                {
                    listOfInts.Add(intNumber);
                }
                else
                {
                    floatNumber = double.Parse(str, System.Globalization.CultureInfo.InvariantCulture);
                    listOfFloats.Add(floatNumber);
                }
            }

            // Now all numbers that are round will be added to list of ints;
            for (int i = 0; i < listOfFloats.Count; i++)
            {
                if (listOfFloats[i] % 1 == 0)
                {
                    listOfInts.Add((int)listOfFloats[i]);
                    listOfFloats.Remove(listOfFloats[i]);
                }
            }

            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}",
               string.Join(", ", listOfFloats),
               listOfFloats.Min(),
               listOfFloats.Max(),
               listOfFloats.Sum(),
               listOfFloats.Sum() / listOfFloats.Count);

            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}",
                string.Join(", ", listOfInts),
                listOfInts.Min(),
                listOfInts.Max(),
                listOfInts.Sum(),
                listOfInts.Sum() / listOfInts.Count);
        }
    }
}
