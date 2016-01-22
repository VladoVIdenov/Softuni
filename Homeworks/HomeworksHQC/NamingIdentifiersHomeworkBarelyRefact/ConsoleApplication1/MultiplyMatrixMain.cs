using System;

namespace ConsoleApplication1
{
    public class MultiplyMatrixMain
    {
        static void Main(string[] args)
        {
            double[,] numbersMatrixOne = new double[,] { { 1, 3 }, { 5, 7 } };
            double[,] numbersMatrixTwo = new double[,] { { 4, 2 }, { 1, 5 } };
            double[,] multipliedMatrix = MultiplyMatrix(numbersMatrixOne, numbersMatrixTwo);

            for (int col = 0; col < multipliedMatrix.GetLength(0); col++)
            {
                for (int row = 0; row < multipliedMatrix.GetLength(1); row++)
                {
                    Console.Write(multipliedMatrix[col, row] + " ");
                }

                Console.WriteLine();
            }
        }

        public static double[,] MultiplyMatrix(double[,] firstArray, double[,] secondArray)
        {
            if (firstArray.GetLength(1) != secondArray.GetLength(0))
            {
                throw new Exception("Error!");
            }

            int matrixLength = firstArray.GetLength(1);
            double[,] multipliedMatrixResult = new double[firstArray.GetLength(0), secondArray.GetLength(1)];
            for (int i = 0; i < multipliedMatrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < multipliedMatrixResult.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixLength; k++)
                    {
                        multipliedMatrixResult[i, j] += firstArray[i, k] * secondArray[k, j];
                    }
                }
            }

            return multipliedMatrixResult;
        }
    }
}