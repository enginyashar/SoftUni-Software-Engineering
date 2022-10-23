using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.FriendListMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Report")
            {
                string[] cmdArgs = input.Split(" ").ToArray();
                string command = cmdArgs[0];

                if (command == "Blacklist")
                {
                    string name = cmdArgs[1];
                    if (friends.Contains(name))
                    {
                        int index = friends.IndexOf(name);
                        friends[index] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (command == "Error")
                {
                    int index = int.Parse(cmdArgs[1]);
                    bool isThisValid = (index >= 0 && index < friends.Count) && (friends[index] != "Blacklisted") && (friends[index] != "Lost");
                    if (isThisValid)
                    {
                        string name = friends[index];
                        friends[index] = "Lost";
                        Console.WriteLine($"{name} was lost due to an error.");
                    }
                }
                else if (command == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newName = cmdArgs[2];

                    if (index >= 0 && index < friends.Count)
                    {
                        string name = friends[index];
                        friends[index] = newName;
                        Console.WriteLine($"{name} changed his username to {newName}.");
                    }
                }
                input = Console.ReadLine();
            } // End of While
            int blacklistCnt = friends.Where(x => x == "Blacklisted").Count();
            int lostListCnt = friends.Where(x => x == "Lost").Count();

            Console.WriteLine($"Blacklisted names: {blacklistCnt}");
            Console.WriteLine($"Lost names: {lostListCnt}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
