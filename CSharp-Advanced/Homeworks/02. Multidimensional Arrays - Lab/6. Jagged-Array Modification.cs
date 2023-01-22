using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] juggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                juggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (row < 0 || col < 0 || row >= rows || col >= rows)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command == "add")
                {
                    juggedArray[row][col] += value;
                }
                if (command == "subtract")
                {
                    juggedArray[row][col] -= value;
                }
            }

            foreach (var arr in juggedArray)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
