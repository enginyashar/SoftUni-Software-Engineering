using System;
using System.Linq;

namespace _08.MagicSum_more
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == n)
                    {
                        Console.WriteLine(string.Join(" ", arr[i], arr[j]));
                    }
                }
            }
        }
    }
}
