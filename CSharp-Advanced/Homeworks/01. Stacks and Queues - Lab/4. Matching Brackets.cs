using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (currentSymbol == '(')
                {
                    indexes.Push(i);
                }
                else if (currentSymbol == ')')
                {
                    int startIndex = indexes.Pop();
                    int count = i - startIndex + 1;
                    string matchingBrackets = input.Substring(startIndex, count);
                    
                    Console.WriteLine(matchingBrackets);
                }
            }
        }
    }
}
