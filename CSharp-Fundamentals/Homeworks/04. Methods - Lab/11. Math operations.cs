using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string operaTor = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(a, operaTor, b));
        }

        private static double Calculate(int num1, string opTor, int num2)
        {
            double result = 0;

            switch (opTor)
            {
                case "+":
                    result = Add(num1, num2);
                    break;
                case "*":
                    result = Multiply(num1, num2);
                    break;
                case "-":
                    result = Subtract(num1, num2);
                    break;
                case "/":
                    result = Divide(num1, num2);
                    break;
            }
            return result;
        }

        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        private static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        private static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        private static double Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
