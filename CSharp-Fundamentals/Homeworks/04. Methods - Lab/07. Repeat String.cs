using System;
using System.Linq;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, n));
        }
        static string RepeatString(string text, int n)
        {
            return string.Concat(Enumerable.Repeat(text, n));
        }
    }
}
