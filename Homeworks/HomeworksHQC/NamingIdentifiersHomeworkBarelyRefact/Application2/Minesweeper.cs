using System;
using Application2;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mines
{
    public class Minesweeper
    {
        private static void Main(string[] аргументи)
        {
            const int MaxScore = 35;
            string command = string.Empty;

            char[,] playBoard = CreateGameBoard();
            char[,] mines = PutMines();

            int personalScore = 0;
            bool isMineExploded = false;
            List<Ratings> ratingList = new List<Ratings>(6);
            int row = 0;
            int col = 0;

            bool isNewGame = true;
            bool isVictory = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play Minesweeper");
                    Console.WriteLine("Try to find all fieald without mines");
                    Console.WriteLine("####################################");
                    Console.WriteLine("Command 'top' :shows ratings");
                    Console.WriteLine("Command 'restart' : begins a new game");
                    Console.WriteLine("Command 'exit' : ending the game");
                    Console.WriteLine("####################################");
                    DrawGameBoard(playBoard);
                    isNewGame = false;
                }

                Console.Write("Please choose row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row <= playBoard.GetLength(0) && col <= playBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GetRating(ratingList);
                        break;
                    case "restart":
                        playBoard = CreateGameBoard();
                        mines = PutMines();
                        DrawGameBoard(playBoard);
                        isMineExploded = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("GoodBye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                tisinahod(playBoard, mines, row, col);
                                personalScore++;
                            }

                            if (MaxScore == personalScore)
                            {
                                isVictory = true;
                            }
                            else
                            {
                                DrawGameBoard(playBoard);
                            }
                        }
                        else
                        {
                            isMineExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (isMineExploded)
                {
                    DrawGameBoard(mines);
                    Console.Write("\nHrrrrrr! You are dead with {0} points. " + "Please enter your Nickname:  ", personalScore);
                    string playerNickname = Console.ReadLine();
                    Ratings currentRating = new Ratings(playerNickname, personalScore);
                    if (ratingList.Count < 5)
                    {
                        ratingList.Add(currentRating);
                    }
                    else
                    {
                        for (int i = 0; i < ratingList.Count; i++)
                        {
                            if (ratingList[i].Points < currentRating.Points)
                            {
                                ratingList.Insert(i, currentRating);
                                ratingList.RemoveAt(ratingList.Count - 1);
                                break;
                            }
                        }
                    }

                    ratingList.Sort((Ratings firstPlayerRating, Ratings secondPlayerRating) => secondPlayerRating.PlayerName.CompareTo(firstPlayerRating.PlayerName));
                    ratingList.Sort((Ratings r1, Ratings r2) => r2.Points.CompareTo(r1.Points));
                    GetRating(ratingList);

                    playBoard = CreateGameBoard();
                    mines = PutMines();
                    personalScore = 0;
                    isMineExploded = false;
                    isNewGame = true;
                }

                if (isVictory)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvori 35 kletki bez kapka kryv.");
                    DrawGameBoard(mines);

                    Console.WriteLine("Please enter your name:  ");
                    string playerName = Console.ReadLine();

                    Ratings points = new Ratings(playerName, personalScore);
                    ratingList.Add(points);
                    GetRating(ratingList);

                    playBoard = CreateGameBoard();
                    mines = PutMines();
                    personalScore = 0;
                    isVictory = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void GetRating(List<Ratings> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, points[i].PlayerName, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void tisinahod(char[,] playBoard, char[,] mines, int row, int col)
        {
            char minesCount = kolko(mines, row, col);
            mines[row, col] = minesCount;
            playBoard[row, col] = minesCount;
        }

        private static void DrawGameBoard(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColumns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> minesCollection = new List<int>();
            while (minesCollection.Count < 15)
            {
                Random random = new Random();
                int minePosition = random.Next(50);
                if (!minesCollection.Contains(minePosition))
                {
                    minesCollection.Add(minePosition);
                }
            }

            foreach (int minePosition in minesCollection)
            {
                int column = minePosition / cols;
                int row = minePosition % cols;
                if (row == 0 && minePosition != 0)
                {
                    column--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameField[column, row - 1] = '*';
            }

            return gameField;
        }

        private static void CreatePlayField(char[,] playField)
        {
            int col = playField.GetLength(0);
            int row = playField.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (playField[i, j] != '*')
                    {
                        char kolkoo = kolko(playField, i, j);
                        playField[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char kolko(char[,] mineField, int row, int col)
        {
            int bombCounter = 0;
            int rowCount = mineField.GetLength(0);
            int colCounter = mineField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mineField[row - 1, col] == '*')
                {
                    bombCounter++;
                }
            }

            if (row + 1 < rowCount)
            {
                if (mineField[row + 1, col] == '*')
                {
                    bombCounter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mineField[row, col - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if (col + 1 < colCounter)
            {
                if (mineField[row, col + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mineField[row - 1, col - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < colCounter))
            {
                if (mineField[row - 1, col + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row + 1 < rowCount) && (col - 1 >= 0))
            {
                if (mineField[row + 1, col - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row + 1 < rowCount) && (col + 1 < colCounter))
            {
                if (mineField[row + 1, col + 1] == '*')
                {
                    bombCounter++;
                }
            }

            return char.Parse(bombCounter.ToString());
        }
    }
}