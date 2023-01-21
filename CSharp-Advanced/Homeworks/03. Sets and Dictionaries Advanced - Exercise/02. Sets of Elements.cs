using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var compare = new HashSet<int>();
            var nSet = new HashSet<int>();
            var mSet = new HashSet<int>();

            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = sizes[0];
            int m = sizes[1];

            for (int i = 0; i < n; i++)
            {
                nSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                mSet.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var nNum in nSet)
            {
                if (mSet.Contains(nNum))
                {
                    Console.Write(nNum + " ");
                }
            }
        }
    }
}
