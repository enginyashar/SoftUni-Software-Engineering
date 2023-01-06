using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();

            foreach (var item in input)
            {
                stack.Push(item.ToString());
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            
        }
    }
}
