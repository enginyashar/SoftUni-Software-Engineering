using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> orders = new Queue<int>(input);

            Console.WriteLine(input.Max());

            while (orders.Count > 0)
            {
                int order = orders.Peek();

                food -= order;

                if (food < 0)
                {
                    Console.WriteLine($"Orders left: " + string.Join(" ", orders));
                    return;
                }
                else
                {
                    orders.Dequeue();
                }
            }
            
            Console.WriteLine("Orders complete");
        }
    }
}
