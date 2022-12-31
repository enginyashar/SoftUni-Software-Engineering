using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string click = Console.ReadLine();
                int mainDigit = click[0] - '0';
                int offset = (mainDigit - 2) * 3;          

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                if (mainDigit == 0)
                {
                    text += ' ';
                }
                else
                {
                    int letNum = offset + click.Length - 1;
                    text += (char)(letNum + 97);
                }
            }
            Console.WriteLine(text);
        }
    }
}
