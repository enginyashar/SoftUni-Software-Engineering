using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int set = input[0];

                if (set == 1)
                {
                    stack.Push(input[1]);    
                }
                else if (set == 2)
                {
                    stack.Pop();
                }
                else if (set == 3)
                {
                    foreach (var num in stack)
                    {
                        if (max < num)
                        {
                            max = num;
                        }
                    }
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(max);
                    }
                }
                else if (set == 4)
                {
                    foreach (var num in stack)
                    {
                        if (min > num)
                        {
                            min = num;
                        }
                    }
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(min);
                    }                    
                }
            }
            Console.WriteLine(string.Join(", ", stack));            
        }
    }
}
