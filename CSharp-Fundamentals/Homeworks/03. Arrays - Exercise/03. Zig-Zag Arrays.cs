using System;
using System.Linq;

namespace _03.Zig_ZagArrays_more
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zig = new int[n];
            int[] zag = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    zig[i] = arr[0];
                    zag[i] = arr[1];
                }
                else
                {
                    zig[i] = arr[1];
                    zag[i] = arr[0];
                }
            }
            Console.WriteLine(string.Join(" ", zig));
            Console.WriteLine(string.Join(" ", zag));            
        }
    }
}
