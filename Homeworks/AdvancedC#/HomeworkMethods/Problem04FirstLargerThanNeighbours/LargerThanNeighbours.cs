namespace Problem04FirstLargerThanNeighbours
{
    using System;

    public class LargerThanNeighbours
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 20, 4, 5, 10, 7, 8, 9, 1100, 5 };
            int[] arr2 = { 3, 2, 20, 70, 5, 10, 7, 8, 9, 10, 5 };
            int[] arr3 = { 6, 2, 0, 4, 100, 10, 7, 8, 9, 10, 100 };
            int[] arr4 = { 6, 2, 0, 4, 5, 10, 11, 20, 21, 22, 100 };

            Console.WriteLine(GetValue(arr));
            Console.WriteLine(GetValue(arr2));
            Console.WriteLine(GetValue(arr3));
            Console.WriteLine(GetValue(arr4));
        }

        private static int GetValue(int[] arr)
        {
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((i > 0) && (i < arr.Length - 1) && (arr[i] > arr[i + 1]) && (arr[i] > arr[i - 1]))
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }

            return index;
        }
    }
}
