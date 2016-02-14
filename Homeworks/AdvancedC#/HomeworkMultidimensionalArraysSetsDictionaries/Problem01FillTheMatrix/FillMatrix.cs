namespace Problem01FillTheMatrix
{
    using System;

    public class FillMatrix
    {
        public static void Main()
        {
            Console.Write("Please enter a the count of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Please enter the count of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            // Pattern A
            // Fill it
            int fillNumber = 1;
            int row = 0;

            for (int col = 0; col < cols; col++)
            {
                for (row = 0; row < rows; row++)
                {
                    matrix[row, col] = fillNumber;
                    fillNumber++;
                }
            }

            // Print Pattern A
            PrintMatrix(matrix);

            Console.WriteLine();

            // Pattern B
            matrix = new int[rows, cols];
            fillNumber = 1;
            row = 0;

            // Fill it
            for (int col = 0; col < cols; col++)
            {
                if (row < rows)
                {
                    for (row = 0; row < rows; row++)
                    {
                        matrix[row, col] = fillNumber;
                        fillNumber++;
                    }
                }
                else if (row == rows)
                {
                    for (row = rows - 1; row >= 0; row--)
                    {
                        matrix[row, col] = fillNumber;
                        fillNumber++;
                    }
                }
            }

            // Print Pattern B
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
