using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> sets = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                sets.Add(Console.ReadLine());
            }

            foreach (var name in sets)
            {
                Console.WriteLine(name);
            }
        }
    }
}
