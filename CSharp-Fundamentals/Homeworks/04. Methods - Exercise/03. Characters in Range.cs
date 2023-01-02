using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            if (ch1 > ch2)
            {
                char temp = ch1;
                ch1 = ch2;
                ch2 = temp;
            }

            CharactersInRange(ch1, ch2);
        }

        static void CharactersInRange(char ch1, char ch2)
        {
            for (int i = ch1 + 1; i < ch2; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
