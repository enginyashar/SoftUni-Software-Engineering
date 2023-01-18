using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> counts = new Dictionary<double, int>();

            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var num in nums)
            {
                if (!counts.ContainsKey(num))
                {
                    counts.Add(num, 0);
                }
                counts[num]++;
            }

            foreach (var (key, value) in counts)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
