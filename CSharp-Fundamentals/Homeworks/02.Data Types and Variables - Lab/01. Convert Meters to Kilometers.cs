using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine()) * 0.001;
            
            Console.WriteLine($"{meter:f2}");
        }
    }
}
