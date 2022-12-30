using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var qty = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var day = Console.ReadLine();

            var price = qty * 1.0;

            if (type == "Students")
            {                
                if (day == "Friday")
                {
                    price *= 8.45;
                }
                else if (day == "Saturday")
                {
                    price *= 9.8;
                }
                else if (day == "Sunday")
                {
                    price *= 10.46;
                }

                if (qty >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price *= 10.9;
                }
                else if (day == "Saturday")
                {
                    price *= 15.6;
                }
                else if (day == "Sunday")
                {
                    price *= 16.0;
                }

                if (qty >= 100)
                {
                    price -= (price * 10.0);
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price *= 15.0;
                }
                else if (day == "Saturday")
                {
                    price *= 20.0;
                }
                else if (day == "Sunday")
                {
                    price *= 22.5;
                }

                if (qty >= 10 && qty <= 20)
                {
                    price *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
