using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> countLetters = new Dictionary<char, int>();
            string text = Console.ReadLine();

            foreach (var ch in text)
            {
                if (!countLetters.ContainsKey(ch))
                {
                    countLetters.Add(ch, 0);
                }
                countLetters[ch]++;
            }

            foreach (var (letter,times) in countLetters.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{letter}: {times} time/s");
            }
        }
    }
}
