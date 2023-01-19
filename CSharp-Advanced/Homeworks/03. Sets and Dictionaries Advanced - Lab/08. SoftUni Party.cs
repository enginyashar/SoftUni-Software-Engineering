using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> party = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                if (input.Length == 8)
                {
                    party.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                party.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(party.Count);
            Console.WriteLine(string.Join(Environment.NewLine, party.OrderBy(s => !char.IsDigit(s[0])).ThenByDescending(s => s)));
        }
    }
}
