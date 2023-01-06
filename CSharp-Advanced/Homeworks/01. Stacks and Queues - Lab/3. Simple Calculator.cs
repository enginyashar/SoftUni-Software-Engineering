using System;
using System.Collections.Generic;
class SimpleCalculator
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        Stack<string> stack = new Stack<string>();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            stack.Push(input[i]);
        }

        while (stack.Count > 1)
        {
            int sum = 0;
            int num = int.Parse(stack.Pop());
            string op = stack.Pop();

            if (op == "+")
            {
                sum = num + int.Parse(stack.Pop());
                stack.Push(sum.ToString());
            }
            else if (op == "-")
            {
                sum = num - int.Parse(stack.Pop());
                stack.Push(sum.ToString());
            }
        }
        Console.WriteLine(stack.Pop());

    }
}
