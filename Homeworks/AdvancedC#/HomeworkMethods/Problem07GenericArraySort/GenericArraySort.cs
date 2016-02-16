namespace Problem07GenericArraySort
{
    using System;

    public class GenericArraySort
    {
        public static void Main()
        {
            // Previous Homework Selection Sort used /Problem02
            int[] myArray = { 1, 6, 15, 99, 6, 18, 2, 3 };
            string[] stringArr = { "zaz", "cba", "baa", "azis", "ungabunga" };
            DateTime[] datesArr = { new DateTime(2002, 3, 1), new DateTime(2012, 12, 24), new DateTime(2016, 02, 16), };

            SelectionSort(myArray);
            SelectionSort(stringArr);
            SelectionSort(datesArr);
            Console.WriteLine(string.Join(", ", myArray));
            Console.WriteLine(string.Join(", ", stringArr));
            Console.WriteLine(string.Join(", ", datesArr));
        }

        public static void SelectionSort<T>(T[] myArray) where T : IComparable
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int indexOfNewMin = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j].CompareTo(myArray[indexOfNewMin]) < 0)
                    {
                        // Store the index of new minimum value
                        indexOfNewMin = j;
                    }
                }

                if (indexOfNewMin != i)
                {
                    T bufferNumber;
                    bufferNumber = myArray[indexOfNewMin];
                    myArray[indexOfNewMin] = myArray[i];
                    myArray[i] = bufferNumber;
                }
            }
        }
    }
}
