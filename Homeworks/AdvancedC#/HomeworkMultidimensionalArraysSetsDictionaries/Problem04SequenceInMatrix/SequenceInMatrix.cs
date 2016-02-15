namespace Problem04SequenceInMatrix
{
    using System;

    public class SequenceInMatrix
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];
            
            // Fill the matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            // the default string and sequence will be the first element on position 0,0!
            string sequenceString = matrix[0, 0];
            int counter = 1;
            int longestSeq = 1;

            // search by lines
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col].Equals(matrix[row, col + 1]))
                    {
                        counter = SequenceInitializer(counter, matrix, row, col, ref longestSeq, ref sequenceString);
                    }
                }

                counter = 1;
            }

            // Search by columns
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col].Equals(matrix[row + 1, col]))
                    {
                        counter = SequenceInitializer(counter, matrix, row, col, ref longestSeq, ref sequenceString);
                    }
                }

                counter = 1;
            }

            // Search in diagonal forward
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col].Equals(matrix[row + 1, col + 1]))
                    {
                        counter = SequenceInitializer(counter, matrix, row, col, ref longestSeq, ref sequenceString);
                    }
                }

                counter = 1;
            }

            // Search in diagonal backwards
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = matrix.GetLength(1) - 1; col > 0; col--)
                {
                    if (matrix[row, col].Equals(matrix[row + 1, col - 1]))
                    {
                        counter = SequenceInitializer(counter, matrix, row, col, ref longestSeq, ref sequenceString);
                    }
                }

                counter = 1;
            }
            
            Console.WriteLine("longestSeq : {0} str : {1}", longestSeq, sequenceString);
        }

        private static int SequenceInitializer(
            int counter,
            string[,] matrix,
            int row,
            int col,
            ref int longestSeq,
            ref string sequenceString)
        {
            counter++;
            if (longestSeq < counter)
            {
                sequenceString = matrix[row, col];
                longestSeq = counter;
            }
            else
            {
                counter = 1;
            }
            return counter;
        }
    }
}
