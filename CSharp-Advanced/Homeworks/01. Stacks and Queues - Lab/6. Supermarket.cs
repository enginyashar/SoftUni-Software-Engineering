using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string name;
            while ((name = Console.ReadLine()) != "End")
            {
                if (name == "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, queue));
                    queue.Clear();
                    continue;
                }
                queue.Enqueue(name);
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
