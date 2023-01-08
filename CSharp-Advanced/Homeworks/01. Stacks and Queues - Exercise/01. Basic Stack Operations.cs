using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
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

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(nums[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (stack.Count > 0)
            {
                int currentNum = stack.Pop();

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
