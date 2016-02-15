namespace Problem05CollectTheCoins
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[][] jaggedStringArr = new string[4][];

            for (int row = 0; row < jaggedStringArr.Length; row++)
            {
                string[] input = Console.ReadLine().Split();
                jaggedStringArr[row] = new string[input.Length];

                for (int col = 0; col < jaggedStringArr.GetLength(1); col++)
                {
                    jaggedStringArr[row][col] = Console.ReadLine();
                }
            }

            for (int i = 0; i < jaggedStringArr.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedStringArr.GetLength(1); j++)
                {
                    Console.Write(jaggedStringArr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
