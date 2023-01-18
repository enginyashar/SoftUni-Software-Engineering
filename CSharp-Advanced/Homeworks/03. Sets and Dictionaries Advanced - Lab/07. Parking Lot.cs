using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split(", ");
                string direction = tokens[0];
                string carNumber = tokens[1];

                if (direction == "IN")
                {
                    parking.Add(carNumber);
                }
                else
                {
                    parking.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parking.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, parking));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
