using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Order(product, quantity);
        }
        
        static void Order(string product, int qty)
        {
            double price = 0.0;
            if (product == "coffee")
            {
                price = 1.5;
            }
            else if (product == "water")
            {
                price = 1.0;
            }
            else if (product == "coke")
            {
                price = 1.4;
            }
            else if (product == "snacks")
            {
                price = 2.0;
            }
            Console.WriteLine($"{price * qty:f2}");
        }
    }
}
