
using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var lightsaberPrice = double.Parse(Console.ReadLine());
            var robePrice = double.Parse(Console.ReadLine());
            var beltPrice = double.Parse(Console.ReadLine());

            int freeBelt = 0;

            if (students >= 6)
            {
                freeBelt = students / 6;
            }

            var total = (Math.Ceiling(students * 1.1) * lightsaberPrice) + (students * robePrice) + ((students - freeBelt) * beltPrice);
            
            if (amount >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                total -= amount;
                Console.WriteLine($"John will need {total:f2}lv more.");
            }
        }
    }
}
