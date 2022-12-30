using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var product = string.Empty;
            var balance = 0.0;
            var currentCoin = 0.0;
            bool isThisProduct = false;
            bool isThisPurchased = true;

            while (input != "Start")
            {
                input = Console.ReadLine();

                if (input == "Start")
                {
                    break;
                }
                else
                {
                    currentCoin = double.Parse(input) * 1.0;
                }

                switch (currentCoin)
                {
                    case 2.0:
                    case 1.0:
                    case 0.5:
                    case 0.2:
                    case 0.1:
                        balance += currentCoin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {currentCoin}");
                        break;
                }
            }

            while (product != "end")
            {
                product = Console.ReadLine().ToLower();
                if (product == "end")
                {
                    Console.WriteLine($"Change: {balance:f2}");
                    return;
                }

                switch (product)
                {
                    case "nuts":
                    case "water":
                    case "crisps":
                    case "soda":
                    case "coke":
                        isThisProduct = true;
                        isThisPurchased = true;
                        break;
                    default:
                        isThisPurchased = false;
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (product == "nuts" && balance >= 2.0)
                {
                    balance -= 2.0;
                }
                else if (product == "water" && balance >= 0.7)
                {
                    balance -= 0.7;
                }
                else if (product == "crisps" && balance >= 1.5)
                {
                    balance -= 1.5;
                }
                else if (product == "soda" && balance >= 0.8)
                {
                    balance -= 0.8;
                }
                else if (product == "coke" && balance >= 1.0)
                {   
                    balance -= 1.0;
                }
                else if (isThisProduct)
                {
                    isThisPurchased = false;
                    Console.WriteLine("Sorry, not enough money");
                }

                if (isThisPurchased)
                {
                    Console.WriteLine($"Purchased {product}");
                }
            }
        }
    }
}

