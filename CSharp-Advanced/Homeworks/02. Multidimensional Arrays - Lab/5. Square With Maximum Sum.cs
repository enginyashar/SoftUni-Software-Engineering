using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareRows = 2;
            int squareCols = 2;
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int maxSum = 0;
            int maxRow = 0;
            int maxCol = 0;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            for (int row = 0; row <= rows - squareRows; row++)
            {                
                for (int col = 0; col <= cols - squareCols; col++)
                {
                    int sum = 0;
                    for (int squareRow = 0; squareRow < squareRows; squareRow++)
                    {                        
                        for (int squareCol = 0; squareCol < squareCols; squareCol++)
                        {
                            sum += matrix[row + squareRow, col + squareCol];
                        }                        
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }                
            }

            for (int squareRow = 0; squareRow < squareRows; squareRow++)
            {
                for (int squareCol = 0; squareCol < squareCols; squareCol++)
                {
                    Console.Write($"{matrix[maxRow + squareRow, maxCol + squareCol]} ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine(maxSum);
        }
    }
}
