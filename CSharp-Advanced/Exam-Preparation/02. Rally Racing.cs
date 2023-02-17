using System;
using System.Linq;

namespace _02._Rally_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string car = Console.ReadLine();

            bool isFirstTunnelFound = false;
            int firstTunnelRow = 0;
            int firstTunnelCol = 0;

            int secondTunnelRow = 0;
            int secondTunnelCol = 0;

            string[,] matrix = new string[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    if (rowData[col] == "T" && !isFirstTunnelFound)
                    {
                        firstTunnelRow = row;
                        firstTunnelCol = col;
                        isFirstTunnelFound = true;
                    }
                    else if (rowData[col] == "T")
                    {
                        secondTunnelRow = row;
                        secondTunnelCol = col;
                    }

                    matrix[row, col] = rowData[col];
                }
            }

            string command = Console.ReadLine().ToLower();
            int carRow = 0;
            int carCol = 0;
            int kms = 0;
            bool isFinished = false;

            while (command != "end")
            {
                if (command == "down")
                {
                    carRow++;
                }
                if (command == "up")
                {
                    carRow--;
                }
                if (command == "right")
                {
                    carCol++;
                }
                if (command == "left")
                {
                    carCol--;
                }

                if (matrix[carRow, carCol] == ".")
                {
                    kms += 10;
                }
                if (matrix[carRow, carCol] == "T")
                {
                    matrix[carRow, carCol] = ".";
                    if (carRow == firstTunnelRow && carCol == firstTunnelCol)
                    {
                        carRow = secondTunnelRow;
                        carCol = secondTunnelCol;
                    }
                    else
                    {
                        carRow = firstTunnelRow;
                        carCol = firstTunnelCol;
                    }
                    matrix[carRow, carCol] = ".";
                    kms += 30;
                }
                if (matrix[carRow, carCol] == "F")
                {
                    kms += 10;
                    isFinished = true;
                    break;
                }
                command = Console.ReadLine().ToLower();
            }

            matrix[carRow, carCol] = "C";

            if (isFinished)
            {
                Console.WriteLine($"Racing car {car} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {car} DNF.");
            }
            Console.WriteLine($"Distance covered {kms} km.");
            PrintMatrix(matrix);
        }
        static void PrintMatrix<T>(T[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
