using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique_More
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int rackCount = 1;

            Stack<int> stack = new Stack<int>() ;

            for (int i = input.Length - 1; i >= 0; i--)
            {            
                int num = input[i];

                sum += num;

                if (sum <= capacity)
                {
                    stack.Push(num);                  
                }
                else
                {
                    rackCount++;
                    sum = num;
                }
            }
            Console.WriteLine(rackCount);
        }
    }
}
