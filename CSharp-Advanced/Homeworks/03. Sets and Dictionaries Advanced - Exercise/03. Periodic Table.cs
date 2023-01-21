using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elem = Console.ReadLine().Split();

                foreach (var item in elem)
                {
                    elements.Add(item);
                }
            }
            foreach (var element in elements.OrderBy(x => x))
            {
                Console.Write(element + " ");
            }
        }
    }
}
