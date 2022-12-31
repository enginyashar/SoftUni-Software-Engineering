using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            string result = string.Empty;

            if (ch >= 65 && ch <= 90)
            {
                result = "upper-case";
            }
            else
            {
                result = "lower-case";
            }
            Console.WriteLine(result);
        }
    }
}
