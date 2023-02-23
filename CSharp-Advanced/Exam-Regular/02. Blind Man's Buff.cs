using System;
using System.Linq;

namespace _02._Blind_Man_s_Buff
{
    class Program
    {
        static void Main()
        {

            string[] size = Console.ReadLine().Split();
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);
            char[,] playground = new char[rows, cols];


            int currentRowPos = -1;
            int currenColPos = -1;

            int obstacle = 0;
            int move = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    playground[row, col] = input[col][0];
                    if (playground[row, col] == 'B')
                    {
                        currentRowPos = row;
                        currenColPos = col;
                    }
                }
            }

            
            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "finish")
                {
                    break;
                }

                int nextRow = currentRowPos;
                int nextCol = currenColPos;

                if (command == "up")
                {
                    nextRow--;
                }
                else if (command == "down")
                {
                    nextRow++;
                }
                else if (command == "left")
                {
                    nextCol--;
                }
                else if (command == "right")
                {
                    nextCol++;
                }
                                
                if (nextRow < 0 || nextCol < 0 || nextRow >= rows || nextCol >= cols)
                {
                    continue;
                }

                char nextPos = playground[nextRow, nextCol];

                if (nextPos == 'O')
                {
                    continue;
                }
                else if (nextPos == 'P')
                {
                    obstacle++;
                    playground[nextRow, nextCol] = '-';

                    if (obstacle == 3)
                    {
                        move++;
                    }
                }

                playground[currentRowPos, currenColPos] = '-';
                playground[nextRow, nextCol] = 'B';

                currentRowPos = nextRow;
                currenColPos = nextCol;

                move++;

                if (obstacle == 3)
                {
                    move--;
                }
            }

            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {obstacle} Moves made: {move}");
        }        
    }
}
