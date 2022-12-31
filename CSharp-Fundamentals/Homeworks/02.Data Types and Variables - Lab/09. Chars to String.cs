using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                result += ch;
            }

            Console.WriteLine(result);
        }
    }
}
