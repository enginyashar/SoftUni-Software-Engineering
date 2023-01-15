using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthesis = new Stack<char>();

            foreach (var ch in input)
            {
                if (ch == '{' || ch == '[' || ch == '(')
                {
                    parenthesis.Push(ch);
                }
                else
                {
                    if (parenthesis.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        char top = parenthesis.Pop();
                        if ((ch == '}' && top != '{') || (ch == ']' && top != '[') || (ch == ')' && top != '('))
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }                    
                }
            }

            if (parenthesis.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
