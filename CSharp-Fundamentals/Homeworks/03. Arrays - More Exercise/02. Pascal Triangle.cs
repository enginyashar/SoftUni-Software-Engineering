using System;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] arr = new long[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = new long[i + 1];
                arr[i][0] = 1;
                arr[i][^1] = 1;

                for (int j = 1; j < i; j++)
                {
                    arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
                }
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(string.Join(" ", arr[j]));
            }
        }
    }
}
