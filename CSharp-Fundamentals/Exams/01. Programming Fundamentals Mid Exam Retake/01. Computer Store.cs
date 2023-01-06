using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0.0;

            while (input != "regular" && input != "special")
            {
                double price = double.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    total += price;
                }
                
                input = Console.ReadLine();
            }
            double tax = total * 0.2;
            double result = total + tax;

            if (result == 0)
            {
                Console.WriteLine("Invalid order!" );
              return;
            }

            if (input == "special")
            {
                result *= 0.9;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {total:f2}$");
            Console.WriteLine($"Taxes: {tax:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {result:f2}$");
        }
    }
}
