namespace _09ParkingSystem
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split();
            int rows = int.Parse(size[0]);

            int cols = int.Parse(size[1]);
            if (rows < 2 || rows > 10000 && cols < 2 || cols > 10000)
            {
                return;
            }
            string inputCoords = Console.ReadLine();
            bool[,] parkingMatrix = new bool[rows, cols];
            List<string> results = new List<string>();
            int linecounter = 1;

            while (inputCoords != "stop" || linecounter == 1000)
            {
                string[] coordinates = inputCoords.Split();

                int entryRow = int.Parse(coordinates[0]);
                int desiredRow = int.Parse(coordinates[1]);
                int desiredCol = int.Parse(coordinates[2]);
                if (entryRow > rows || entryRow < 0 || desiredRow > rows || desiredRow < 0 || desiredCol > cols || desiredCol < 0 )
                {
                    return;
                }
                
                if (entryRow <= desiredRow)
                {
                    for (int r = entryRow; r <= desiredRow; r++)
                    {
                        for (int c = 0; c <= parkingMatrix.GetLength(1); c++)
                        {
                            if (desiredRow == r && desiredCol == c)
                            {
                                if (parkingMatrix[r, c] == true)
                                {
                                    for (int k = c, l = c; k < parkingMatrix.GetLength(0) && c > 0; k++, c--)
                                    {
                                        if ((parkingMatrix[r, k + 1] == false || parkingMatrix[r, l - 1] == false) && (k + 1 <= parkingMatrix.GetLength(0) || l - 1 > 0))
                                        {
                                            if (parkingMatrix[r, l - 1] == false)
                                            {
                                                parkingMatrix[r, l - 1] = true;
                                                results.Add((Math.Abs(l + (Math.Abs(entryRow - desiredCol)))).ToString());
                                                break;
                                            }
                                            else if (parkingMatrix[r, k + 1] == false)
                                            {
                                                parkingMatrix[r, k + 1] = true;
                                                results.Add((Math.Abs(k + 2 + (Math.Abs(entryRow - desiredCol)))).ToString());
                                                break;
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Row {0} full", desiredRow);
                                            break;
                                        }
                                    }
                                }
                                else if (parkingMatrix[r, c] == false)
                                {
                                    parkingMatrix[r, c] = true;
                                    results.Add((Math.Abs(c + 1 + (Math.Abs(entryRow - desiredCol)))).ToString());
                                    break;
                                }
                            }
                        }

                    }
                }
                else
                {
                    for (int r = entryRow; r >= desiredRow; r--)
                    {
                        for (int c = 0; c <= parkingMatrix.GetLength(1); c++)
                        {
                            if (desiredRow == r && desiredCol == c)
                            {
                                if (parkingMatrix[r, c] == true)
                                {
                                    for (int k = c, l = c; k < parkingMatrix.GetLength(0) && c > 0; k++, c--)
                                    {
                                        if (k + 1 < parkingMatrix.GetLength(0) && l - 1 > 0)
                                        {
                                            if ((parkingMatrix[r, k + 1] == false || parkingMatrix[r, l - 1] == false))
                                            {
                                                if (parkingMatrix[r, l - 1] == false)
                                                {
                                                    parkingMatrix[r, l - 1] = true;
                                                    results.Add((Math.Abs(l + (Math.Abs(entryRow - desiredCol)) + 1)).ToString());
                                                    break;
                                                }
                                                else if (parkingMatrix[r, k + 1] == false)
                                                {
                                                    parkingMatrix[r, k + 1] = true;
                                                    results.Add((Math.Abs(k + 1 + (Math.Abs(entryRow - desiredCol)) + 1)).ToString());
                                                    break;
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                    }
                                    string result = string.Format("Row {0} full", desiredRow);
                                    results.Add(result);
                                    break;
                                }
                                else if (parkingMatrix[r, c] == false)
                                {
                                    parkingMatrix[r, c] = true;
                                    results.Add((Math.Abs(c + 1 + (Math.Abs(entryRow - desiredCol)))).ToString());
                                    break;
                                }
                            }
                        }
                    }
                }

                inputCoords = Console.ReadLine();
                linecounter++;
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }


    }
}
