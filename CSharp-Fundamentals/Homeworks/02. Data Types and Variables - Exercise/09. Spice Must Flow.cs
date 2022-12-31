using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint yield = uint.Parse(Console.ReadLine());
            uint totalSpices = 0;
            int days = 0;
            
            while (yield >= 100)
            {
                totalSpices += (yield - 26);
                days++;
                yield -= 10;

                if (yield < 100)
                {
                    totalSpices -= 26;                                 
                    break;
                }                                
            }
            Console.WriteLine($"{days}\n{totalSpices}");
        }
    }
}
