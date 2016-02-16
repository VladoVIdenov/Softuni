namespace Problem03LargerThanNeighbours
{
    using System;
    using System.Security.AccessControl;

    public class LargerThanNeighbours
    {
        public static void Main()
        {
            int[] arr = { 3, 2, 20, 4, 5, 10, 7, 8, 9, 10, 5 };
            
            bool isGreater = false;

            for (int i = 0; i < arr.Length; i++)
            {
                isGreater = CheckIsGreater(arr, i);
                Console.WriteLine(isGreater);
            }
        }

        private static bool CheckIsGreater(int[] arr, int i)
        {
            bool isGreater = false;
            if (i == 0)
            {
                if (arr[i] > arr[i + 1])
                {
                    isGreater = true;
                }
                else
                {
                    isGreater = false;
                }
            }
            else if (i == arr.Length - 1)
            {
                if (arr[i] > arr[i - 1])
                {
                    isGreater = true;
                }
                else
                {
                    isGreater = false;
                }
            }
            else
            {
                if ((arr[i] > arr[i + 1]) && (arr[i] > arr[i - 1]))
                {
                    isGreater = true;
                }
                else
                {
                    isGreater = false;
                }
            }

            return isGreater;
        }
    }
}
