using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stackNums = new Stack<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                stackNums.Push(nums[i]);
            }

            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] commandInfo = input.Split();
                string command = commandInfo[0];

                if (command == "add")
                {
                    int a = int.Parse(commandInfo[1]);
                    int b = int.Parse(commandInfo[2]);

                    stackNums.Push(a);
                    stackNums.Push(b);
                }
                else if (command == "remove")
                {
                    int count = int.Parse(commandInfo[1]);

                    if (stackNums.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stackNums.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stackNums.Sum()}");
        }
    }
}
