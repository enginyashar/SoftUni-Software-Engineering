using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = cmdArgs[0];

                if (command == "Add")
                {
                    string cardName = cmdArgs[1];
                    if (cards.Contains(cardName))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cards.Add(cardName);
                        Console.WriteLine("Card successfully added");
                    }                    
                }
                else if (command == "Remove")
                {
                    string cardName = cmdArgs[1];
                    if (cards.Contains(cardName))
                    {
                        cards.Remove(cardName);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {                        
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index > 0 && index <= cards.Count - 1)
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string cardName = cmdArgs[2];

                    if (index < 0 || index > cards.Count - 1)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (cards.Contains(cardName))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else
                    {
                        cards.Insert(index, cardName);
                        Console.WriteLine("Card successfully added");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
