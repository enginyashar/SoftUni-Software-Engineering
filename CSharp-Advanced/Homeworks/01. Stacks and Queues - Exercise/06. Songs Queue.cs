using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songs = new Queue<string>(list);

            
            while (songs.Count > 0)
            {
                List<string> input = new List<string>(Console.ReadLine().Split());
                string command = input[0];
                input.Remove(command);
                string song = string.Join(" ", input);

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
