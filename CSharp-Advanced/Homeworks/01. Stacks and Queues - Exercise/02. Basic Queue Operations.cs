using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            int smallest = int.MaxValue;

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(nums[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (queue.Count > 0)
            {
                int currentNum = queue.Dequeue();

                if (currentNum == x)
                {
                    Console.WriteLine(true.ToString().ToLower());
                    return;
                }

                if (smallest > currentNum)
                {
                    smallest = currentNum;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
