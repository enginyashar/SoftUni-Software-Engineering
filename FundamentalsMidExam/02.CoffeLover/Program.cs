using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CoffeLover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffee = Console.ReadLine()
                .Split(" ")
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                string command = cmdArgs[0];

                if (command == "Include")
                {
                    string addCoffee = cmdArgs[1];
                    coffee.Add(addCoffee);
                }
                else if (command == "Remove")
                {
                    string index = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);

                    if (index == "first" && count <= coffee.Count)
                    {
                        coffee.RemoveRange(0, count);
                    }
                    else if (index == "last" && count <= coffee.Count)
                    {
                        coffee.RemoveRange(coffee.Count - count, count);
                    }
                }
                else if (command == "Prefer")
                {
                    int preferFirst = int.Parse(cmdArgs[1]);
                    int preferSecond = int.Parse(cmdArgs[2]);
                    if (coffee.Count - 1 >= preferFirst && coffee.Count - 1 >= preferSecond)
                    {
                        string temp = coffee[preferFirst];
                        coffee[preferFirst] = coffee[preferSecond];
                        coffee[preferSecond] = temp;
                    }

                }
                else
                {
                    coffee.Reverse();
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffee));
        }
    }
}
