using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            if (type == "int")
            {
                Console.WriteLine(GetInteger(input));
            }
            else if (type == "real")
            {
                Console.WriteLine($"{GetDouble(input):f2}");
            }
            else if (type == "string")
            {
                Console.WriteLine($"${input}$");
            }

        }

        static int GetInteger(string input)
        {
            return int.Parse(input) * 2;
        }
        static double GetDouble(string input)
        {
            return double.Parse(input) * 1.5;
        }
    }
}
