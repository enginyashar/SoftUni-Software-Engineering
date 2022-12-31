using System;

namespace _02.PrintNumbersinReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];

            for (int i = input.Length - 1; i >= 0; i--)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
