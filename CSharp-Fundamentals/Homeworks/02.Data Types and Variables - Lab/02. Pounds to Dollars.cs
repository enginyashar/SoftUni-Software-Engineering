using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pound = double.Parse(Console.ReadLine()) * 1.31;
            
            Console.WriteLine($"{pound:f3}");
        }
    }
}
