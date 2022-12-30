using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            var total = hour * 60 + min + 30;
            hour = total / 60;
            min = total % 60;
            
            if (hour > 23)
            {
                hour = 0;
            }
            
            Console.WriteLine($"{hour}:{min:D2}");
        }
    }
}
