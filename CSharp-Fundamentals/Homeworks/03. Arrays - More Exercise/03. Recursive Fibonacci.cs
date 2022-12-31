using System;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                return;
            }

            int[] fibonacci = new int[n];
            fibonacci[0] = 1;

            if (n == 1)
            {
                Console.WriteLine(fibonacci[0]);
                return;
            }

            fibonacci[1] = 1;
            
            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            Console.WriteLine(fibonacci[^1]);
        }
    }
}
