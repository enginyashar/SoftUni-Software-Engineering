using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double spent = currentBalance;
            string game = string.Empty;
            double cost;

            while ((game = Console.ReadLine()) != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        cost = 39.99;
                        break;
                    case "CS: OG":
                        cost = 15.99;
                        break;
                    case "Zplinter Zell":
                        cost = 19.99;
                        break;
                    case "Honored 2":
                        cost = 59.99;
                        break;
                    case "RoverWatch":
                        cost = 29.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (cost > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    currentBalance -= cost;
                    Console.WriteLine($"Bought {game}");

                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
            }
            Console.WriteLine($"Total spent: ${spent - currentBalance:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
