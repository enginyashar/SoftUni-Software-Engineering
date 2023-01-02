using System;

namespace _03.Calculations
{
    class Program 
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Number(operation, a, b);
        }
        
        static void Number(string operation, int a, int b)
        {
            int result = 0;
            
            if (operation == "divide")
            {
                result = a / b;
            }
            else if (operation == "multiply")
            {
                result = a * b;
            }
            else if (operation == "subtract")
            {
                result = a - b;
            }
            else if (operation == "add")
            {
                result = a + b;
            }
            Console.WriteLine($"{result}");
        }
    }
}
