using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text.Length % 2 == 0)
            {
                EvenMiddleChars(text);
            }
            else
            {
                OddMiddleChar(text);
            }
        }

        static void OddMiddleChar(string text)
        {
            int middleChar = text.Length / 2;   //Found middle character position in text

            Console.WriteLine(text[middleChar]);
        }

        static void EvenMiddleChars(string text)
        {
            int firstMiddle = (text.Length / 2) - 1;    //Found first middle character position in text
            int secondMiddle = text.Length / 2;    //Found second middle character position in text

            Console.WriteLine(text[firstMiddle].ToString() + text[secondMiddle].ToString());
        }
    }
}
