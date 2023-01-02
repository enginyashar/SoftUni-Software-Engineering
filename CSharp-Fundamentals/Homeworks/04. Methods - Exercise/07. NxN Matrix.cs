using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                NxNMatrix(n);
            }            
        }

        static void NxNMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
