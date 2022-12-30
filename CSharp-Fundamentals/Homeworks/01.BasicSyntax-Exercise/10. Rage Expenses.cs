using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCnt = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double total = ((lostGameCnt / 12) * displayPrice ) + ((lostGameCnt / 6) * keyboardPrice) + ((lostGameCnt / 3) * mousePrice) + ((lostGameCnt / 2) * headsetPrice);

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}

