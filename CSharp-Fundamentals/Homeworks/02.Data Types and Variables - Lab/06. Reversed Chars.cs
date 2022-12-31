using System;

namespace _6.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = string.Empty;

            for (int i = 1; i <= 3; i++)
            {
                ch += Console.ReadLine();
            }

            string convert = ch;
            ch = string.Empty;

            for (int j = convert.Length - 1; j >= 0 ; j--)
            {
                ch += convert[j] + " ";
            }

            Console.WriteLine(ch);
        }
    }
}
