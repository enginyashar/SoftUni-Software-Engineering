using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(VowelsCount(text));
        }

        static int VowelsCount(string text)
        {
            int count = 0;
            foreach (char ch in text.ToLower())
            {
                switch (ch)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
