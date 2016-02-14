namespace Problem03MatrixShuffling
{
    using System;

    public class MatrixShuffling
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            int row1 = 0;
            int col1 = 0;
            int row2 = 0;
            int col2 = 0;

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputString = input.Split(' ');

                if (inputString[0] == "swap" && inputString.Length == 5 && inputString.Length == 5)
                {
                    row1 = int.Parse(inputString[1]);
                    col1 = int.Parse(inputString[3]);
                    row2 = int.Parse(inputString[2]);
                    col2 = int.Parse(inputString[4]);

                    if ((row1 >= 0 && row1 < rows) && (row2 >= 0 && row2 < rows) && (col1 >= 0 && col1 < cols)
                        && (col2 >= 0 && col2 < cols))
                    {
                        Swap(matrix, row1, col1, row2, col2);

                        PrintMatrix(matrix);
                    }
                    else
                    {
                        PrintErrorMessage();
                    }
                }
                else
                {
                    PrintErrorMessage();
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
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

        private static void PrintErrorMessage()
        {
            Console.WriteLine("Invalid input!");
        }

        private static void Swap(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            string bufferString = string.Empty;

            bufferString = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = bufferString;
        }
    }
}
